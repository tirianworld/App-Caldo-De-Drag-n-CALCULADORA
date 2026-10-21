using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class PersistentButtonActions : MonoBehaviour
{
    public bool useButton = true;
    public bool usarSincronizacionGlobal = true; // Controla sincronización global o local
    public Button[] myButtons; // AHORA ES UN ARRAY
    public string uniqueID;
    public List<GameObject> objectsToCycle = new List<GameObject>();

    private List<string> objectKeys = new List<string>();
    private int currentIndex = 0;

    private static Dictionary<string, int> sharedIndices = new Dictionary<string, int>();
    private static Dictionary<string, List<PersistentButtonActions>> instancesByID = new Dictionary<string, List<PersistentButtonActions>>();

    private void Awake()
    {
        if (usarSincronizacionGlobal)
        {
            if (!instancesByID.ContainsKey(uniqueID))
                instancesByID[uniqueID] = new List<PersistentButtonActions>();

            instancesByID[uniqueID].Add(this);
        }
    }

    private void OnDestroy()
    {
        if (usarSincronizacionGlobal && instancesByID.ContainsKey(uniqueID))
            instancesByID[uniqueID].Remove(this);
    }

    private void Start()
    {
        if (objectsToCycle == null || objectsToCycle.Count == 0)
        {
            Debug.LogError("La lista 'objectsToCycle' está vacía.");
            return;
        }

        string sceneName = SceneManager.GetActiveScene().name;

        for (int i = 0; i < objectsToCycle.Count; i++)
        {
            if (objectsToCycle[i] == null)
            {
                Debug.LogWarning($"El objeto en el índice {i} está vacío.");
                continue;
            }

            string key = $"{sceneName}_{uniqueID}_{objectsToCycle[i].name}_Active_{i}";
            objectKeys.Add(key);
        }

        string indexKey = GetPlayerPrefsKey();

        if (usarSincronizacionGlobal && sharedIndices.ContainsKey(uniqueID))
        {
            currentIndex = sharedIndices[uniqueID];
        }
        else if (PlayerPrefs.HasKey(indexKey))
        {
            currentIndex = PlayerPrefs.GetInt(indexKey);
            if (usarSincronizacionGlobal)
                sharedIndices[uniqueID] = currentIndex;
        }
        else
        {
            for (int i = 0; i < objectKeys.Count; i++)
            {
                if (PlayerPrefs.GetInt(objectKeys[i], i == 0 ? 1 : 0) == 1)
                {
                    currentIndex = i;
                    break;
                }
            }

            PlayerPrefs.SetInt(indexKey, currentIndex);
            if (usarSincronizacionGlobal)
                sharedIndices[uniqueID] = currentIndex;
        }

        ApplyIndex(currentIndex);

        if (useButton)
        {
            if (myButtons == null || myButtons.Length == 0)
            {
                Debug.LogError("No se asignaron botones en 'myButtons'.");
                return;
            }

            foreach (Button btn in myButtons)
            {
                if (btn != null)
                    btn.onClick.AddListener(OnButtonClick);
            }
        }
    }

    private void OnButtonClick()
    {
        if (objectsToCycle.Count == 0)
            return;

        int newIndex = currentIndex;
        do
        {
            newIndex = (newIndex + 1) % objectsToCycle.Count;
        } while (objectsToCycle[newIndex] == null);

        UpdateSharedIndex(newIndex);
    }

    private void UpdateSharedIndex(int newIndex)
    {
        currentIndex = newIndex;

        string indexKey = GetPlayerPrefsKey();
        PlayerPrefs.SetInt(indexKey, newIndex);

        for (int i = 0; i < objectKeys.Count; i++)
        {
            PlayerPrefs.SetInt(objectKeys[i], i == newIndex ? 1 : 0);
        }

        PlayerPrefs.Save();

        if (usarSincronizacionGlobal)
        {
            sharedIndices[uniqueID] = newIndex;

            if (instancesByID.TryGetValue(uniqueID, out var instances))
            {
                foreach (var instance in instances)
                    instance.ApplyIndex(newIndex);
            }
        }
        else
        {
            ApplyIndex(newIndex);
        }
    }

    private void ApplyIndex(int index)
    {
        currentIndex = index;

        for (int i = 0; i < objectsToCycle.Count; i++)
        {
            if (objectsToCycle[i] != null)
                objectsToCycle[i].SetActive(i == index);
        }
    }

    private string GetPlayerPrefsKey()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        if (usarSincronizacionGlobal)
        {
            return $"Persistent_Index_{uniqueID}";
        }
        else
        {
            return $"Persistent_Index_{uniqueID}_{gameObject.GetInstanceID()}";
        }
    }
}
