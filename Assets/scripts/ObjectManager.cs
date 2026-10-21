using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class ObjectManager : MonoBehaviour
{
    public GameObject prefab; // Prefab del GameObject a instanciar
    public GameObject bossPrefab; // Prefab del boss a instanciar
    public Button addButton; // Botón para instanciar el GameObject
    public Button removeButton; // Botón para eliminar el GameObject
    public Button bossButton; // Botón para instanciar o eliminar el boss
    public TextMeshProUGUI countText; // Texto UI para mostrar la cantidad de objetos
    public Transform parentTransform; // Transform del GameObject padre

    private List<GameObject> instantiatedObjects = new List<GameObject>(); // Lista para almacenar los objetos instanciados
    private int objectCount = 0; // Contador de objetos
    private GameObject bossObject; // Referencia al boss instanciado

    void Start()
    {
        LoadObjectCount(); // Cargar el contador de objetos desde PlayerPrefs

        // Crear los objetos iniciales
        for (int i = 0; i < objectCount; i++)
        {
            GameObject newObject = Instantiate(prefab, parentTransform);
            instantiatedObjects.Add(newObject);
        }

        addButton.onClick.AddListener(AddObject); // Añadir listener al botón de añadir
        removeButton.onClick.AddListener(RemoveObject); // Añadir listener al botón de eliminar
        bossButton.onClick.AddListener(ToggleBoss); // Añadir listener al botón de instanciar o eliminar el boss
        UpdateCountText(); // Actualizar el texto con la cantidad de objetos
    }

    void AddObject()
    {
        GameObject newObject = Instantiate(prefab, parentTransform); // Instanciar el nuevo objeto como hijo del GameObject padre
        instantiatedObjects.Add(newObject); // Añadir el objeto a la lista
        objectCount++; // Incrementar el contador de objetos
        SaveObjectCount(); // Guardar el contador de objetos en PlayerPrefs
        UpdateCountText(); // Actualizar el texto con la cantidad de objetos
    }

    void RemoveObject()
    {
        if (instantiatedObjects.Count > 0)
        {
            GameObject objectToRemove = instantiatedObjects[instantiatedObjects.Count - 1]; // Obtener el último objeto instanciado
            instantiatedObjects.RemoveAt(instantiatedObjects.Count - 1); // Eliminarlo de la lista
            Destroy(objectToRemove); // Destruir el objeto
            objectCount--; // Decrementar el contador de objetos
            SaveObjectCount(); // Guardar el contador de objetos en PlayerPrefs
            UpdateCountText(); // Actualizar el texto con la cantidad de objetos
        }
    }

    void ToggleBoss()
    {
        if (bossObject == null)
        {
            bossObject = Instantiate(bossPrefab, parentTransform); // Instanciar el boss como hijo del GameObject padre
        }
        else
        {
            Destroy(bossObject); // Eliminar el boss
            bossObject = null; // Establecer la referencia del boss a null
        }
    }

    void UpdateCountText()
    {
        countText.text = "" + objectCount; // Actualizar el texto UI
    }

    void SaveObjectCount()
    {
        PlayerPrefs.SetInt("ObjectCount", objectCount); // Guardar el contador de objetos en PlayerPrefs
        PlayerPrefs.Save(); // Asegurarse de que los datos se guarden
    }

    void LoadObjectCount()
    {
        objectCount = PlayerPrefs.GetInt("ObjectCount", 0); // Cargar el contador de objetos desde PlayerPrefs (por defecto 0)
    }
}
