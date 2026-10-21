using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gold : MonoBehaviour
{
    
    public TMP_InputField inputField;
    public TMP_Text numberText;

    public GameObject[] goldDependentObjects;
    public LogIn login;
    public float savedNumber = 0;

    // Variables para cada usuario
    public float RaxxarsavedNumber = 0;
    public float PrometeosavedNumber = 0;
    public float KaironsavedNumber = 0;
    public float BarlemsavedNumber = 0;
    public float RagnavaldrsavedNumber = 0;
    public float AlmaFellassavedNumber = 0;
    public float PepeLouysavedNumber = 0;
    public SendToGoogle SendToGoogle;


    // Claves para PlayerPrefs
    public const string playerPrefsKey = "SavedNumber";
    public const string RaxxarsavedNumberKey = "RaxxarSavedNumber";
    public const string PrometeosavedNumberKey = "PrometeoSavedNumber";
    public const string KaironsavedNumberKey = "KaironSavedNumber";
    public const string BarlemsavedNumberKey = "BarlemSavedNumber";
    public const string RagnavaldrsavedNumberKey = "RagnavaldrSavedNumber";
    public const string AlmaFellassavedNumberKey = "AlmaFellasSavedNumber";
    public const string PepeLouysavedNumberKey = "PepeLouysavedNumber";


    private void Awake()
    {
        login = GameObject.Find("Usuary").GetComponent<LogIn>();
    }

    private void Start()
    {
        ShowUsersGold();
        // Cargar valores desde PlayerPrefs al inicio
        if (PlayerPrefs.HasKey(playerPrefsKey))
        {
            savedNumber = PlayerPrefs.GetFloat(playerPrefsKey);
            numberText.text = savedNumber.ToString();
        }

        // Cargar valores para cada usuario
        RaxxarsavedNumber = PlayerPrefs.GetFloat(RaxxarsavedNumberKey, 0);
        PrometeosavedNumber = PlayerPrefs.GetFloat(PrometeosavedNumberKey, 0);
        KaironsavedNumber = PlayerPrefs.GetFloat(KaironsavedNumberKey, 0);
        BarlemsavedNumber = PlayerPrefs.GetFloat(BarlemsavedNumberKey, 0);
        RagnavaldrsavedNumber = PlayerPrefs.GetFloat(RagnavaldrsavedNumberKey, 0);
        AlmaFellassavedNumber = PlayerPrefs.GetFloat(AlmaFellassavedNumberKey, 0);
        PepeLouysavedNumber = PlayerPrefs.GetFloat(PepeLouysavedNumberKey, 0);


        UpdateGoldDependentObjectsVisibility();
    }
    void OnApplicationQuit()
    {
        // Guardar los valores al cerrar la aplicación o la escena
        PlayerPrefs.SetFloat(playerPrefsKey, savedNumber);
        PlayerPrefs.SetFloat(RaxxarsavedNumberKey, RaxxarsavedNumber);
        PlayerPrefs.SetFloat(PrometeosavedNumberKey, PrometeosavedNumber);
        PlayerPrefs.SetFloat(KaironsavedNumberKey, KaironsavedNumber);
        PlayerPrefs.SetFloat(BarlemsavedNumberKey, BarlemsavedNumber);
        PlayerPrefs.SetFloat(RagnavaldrsavedNumberKey, RagnavaldrsavedNumber);
        PlayerPrefs.SetFloat(AlmaFellassavedNumberKey, AlmaFellassavedNumber);
        PlayerPrefs.SetFloat(PepeLouysavedNumberKey, PepeLouysavedNumber);

        PlayerPrefs.Save();
    }

    void OnDestroy()
    {
        // Opcionalmente, también puedes usar OnDestroy si deseas asegurar el guardado cuando el objeto se destruya
        PlayerPrefs.SetFloat(playerPrefsKey, savedNumber);
        PlayerPrefs.SetFloat(RaxxarsavedNumberKey, RaxxarsavedNumber);
        PlayerPrefs.SetFloat(PrometeosavedNumberKey, PrometeosavedNumber);
        PlayerPrefs.SetFloat(KaironsavedNumberKey, KaironsavedNumber);
        PlayerPrefs.SetFloat(BarlemsavedNumberKey, BarlemsavedNumber);
        PlayerPrefs.SetFloat(RagnavaldrsavedNumberKey, RagnavaldrsavedNumber);
        PlayerPrefs.SetFloat(AlmaFellassavedNumberKey, AlmaFellassavedNumber);
        PlayerPrefs.SetFloat(PepeLouysavedNumberKey, PepeLouysavedNumber);

        PlayerPrefs.Save();
    }

    void Update()
    {
        // Actualizar valores para cada usuario
        if (login.Anibal == true)
        {
            RaxxarsavedNumber = savedNumber;
        }
        if (login.Pablo == true)
        {
            PrometeosavedNumber = savedNumber;
        }
        if (login.Armando == true)
        {
            KaironsavedNumber = savedNumber;
        }
        if (login.Ruben == true)
        {
            BarlemsavedNumber = savedNumber;
        }
        if (login.Samuel == true)
        {
            AlmaFellassavedNumber = savedNumber;
        }
        if (login.Chispo == true)
        {
            RagnavaldrsavedNumber = savedNumber;
        }
        if (login.Jaime == true)
        {
            PepeLouysavedNumber = savedNumber;
        }
    }
    public void SaveNumber()
    {
        if (float.TryParse(inputField.text, out float inputNumber))
        {
            savedNumber = inputNumber;
            numberText.text = savedNumber.ToString();

            PlayerPrefs.SetFloat(playerPrefsKey, savedNumber);
            PlayerPrefs.SetFloat(RaxxarsavedNumberKey, RaxxarsavedNumber);
            PlayerPrefs.SetFloat(PrometeosavedNumberKey, PrometeosavedNumber);
            PlayerPrefs.SetFloat(KaironsavedNumberKey, KaironsavedNumber);
            PlayerPrefs.SetFloat(BarlemsavedNumberKey, BarlemsavedNumber);
            PlayerPrefs.SetFloat(RagnavaldrsavedNumberKey, RagnavaldrsavedNumber);
            PlayerPrefs.SetFloat(AlmaFellassavedNumberKey, AlmaFellassavedNumber);
            PlayerPrefs.SetFloat(PepeLouysavedNumberKey, PepeLouysavedNumber);

            PlayerPrefs.Save();

            UpdateGoldDependentObjectsVisibility();

        }
        inputField.text = "";
    }

    public void AddNumber()
    {
        if (float.TryParse(inputField.text, out float inputNumber))
        {
            savedNumber += inputNumber;
            numberText.text = savedNumber.ToString();

            PlayerPrefs.SetFloat(playerPrefsKey, savedNumber);
            PlayerPrefs.Save();
            UpdateGoldDependentObjectsVisibility();

           
        }
        inputField.text = "";
    }
    public void SavePlayerNumber()
    {
        
        {
            



            PlayerPrefs.SetFloat(playerPrefsKey, savedNumber);
            PlayerPrefs.SetFloat(RaxxarsavedNumberKey, RaxxarsavedNumber);
            PlayerPrefs.SetFloat(PrometeosavedNumberKey, PrometeosavedNumber);
            PlayerPrefs.SetFloat(KaironsavedNumberKey, KaironsavedNumber);
            PlayerPrefs.SetFloat(BarlemsavedNumberKey, BarlemsavedNumber);
            PlayerPrefs.SetFloat(RagnavaldrsavedNumberKey, RagnavaldrsavedNumber);
            PlayerPrefs.SetFloat(AlmaFellassavedNumberKey, AlmaFellassavedNumber);
            PlayerPrefs.SetFloat(PepeLouysavedNumberKey, PepeLouysavedNumber);

            PlayerPrefs.Save();

            UpdateGoldDependentObjectsVisibility();

        }
        
    }

    public void SubtractNumber()
    {
        if (float.TryParse(inputField.text, out float inputNumber))
        {
            savedNumber -= inputNumber;
            numberText.text = savedNumber.ToString();
            PlayerPrefs.SetFloat(playerPrefsKey, savedNumber);
            PlayerPrefs.Save();
            UpdateGoldDependentObjectsVisibility();



           
        }
        inputField.text = "";
    }


    public void UpdateGoldDependentObjectsVisibility()
    {
        for (int i = 0; i < goldDependentObjects.Length; i++)
        {
            GameObject obj = goldDependentObjects[i];
            obj.SetActive(false);

            // Activa el objeto basado en su índice en el array.
            if (i == 0 && savedNumber < 0)
            {
                obj.SetActive(true);
            }
            else if (i == 1 && savedNumber >= 0 && savedNumber <= 50)
            {
                obj.SetActive(true);
            }
            else if (i == 2 && savedNumber > 50 && savedNumber <= 10000)
            {
                obj.SetActive(true);
            }
            else if (i == 3 && savedNumber > 10000)
            {
                obj.SetActive(true);
            }
            else if (i == 4 && savedNumber > 100000)
            {
                obj.SetActive(true);
            }
        }
    }
    public void ShowUsersGold()
    {
        if (login.Anibal == true)
        {
            savedNumber = RaxxarsavedNumber;
            numberText.text = savedNumber.ToString();
            UpdateGoldDependentObjectsVisibility();
        }
        if (login.Pablo == true)
        {
            savedNumber = PrometeosavedNumber;
            numberText.text = savedNumber.ToString();
            UpdateGoldDependentObjectsVisibility();

        }
        if (login.Armando == true)
        {
            savedNumber = KaironsavedNumber;
            numberText.text = savedNumber.ToString();
            UpdateGoldDependentObjectsVisibility();

        }
        if (login.Ruben == true)
        {
            savedNumber = BarlemsavedNumber;
            numberText.text = savedNumber.ToString();
            UpdateGoldDependentObjectsVisibility();

        }
        if (login.Samuel == true)
        {
            savedNumber = AlmaFellassavedNumber;
            numberText.text = savedNumber.ToString();
            UpdateGoldDependentObjectsVisibility();

        }
        if (login.Chispo == true)
        {
            savedNumber = RagnavaldrsavedNumber;
            numberText.text = savedNumber.ToString();
            UpdateGoldDependentObjectsVisibility();

        }
        if (login.Jaime == true)
        {
            savedNumber = PepeLouysavedNumber;
            numberText.text = savedNumber.ToString();
            UpdateGoldDependentObjectsVisibility();

        }
    }
}
