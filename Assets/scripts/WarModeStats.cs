using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;



public class WarModeStats : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text numberText;
    public GameObject[] playerButtons;

    private Dictionary<string, float> savedNumbers = new Dictionary<string, float>();

    public bool Jaime;
    public bool Anibal;
    public bool Pablo;
    public bool Armando;
    public bool Ruben;
    public bool Samuel;
    public bool Chispo;

    public float savedNumber = 0;

    // Variables para cada usuario
    public float RaxxarsavedNumber = 0;
    public float PrometeosavedNumber = 0;
    public float KaironsavedNumber = 0;
    public float BarlemsavedNumber = 0;
    public float RagnavaldrsavedNumber = 0;
    public float AlmaFellassavedNumber = 0;

    // Claves para PlayerPrefs
    private const string playerPrefsKey = "LifeNumber";
    private const string RaxxarsavedNumberKey = "RaxxarLifeNumber";
    private const string PrometeosavedNumberKey = "PrometeoLifeNumber";
    private const string KaironsavedNumberKey = "KaironLifeNumber";
    private const string BarlemsavedNumberKey = "BarlemLifeNumber";
    private const string RagnavaldrsavedNumberKey = "RagnavaldrLifeNumber";
    private const string AlmaFellassavedNumberKey = "AlmaFellasLifeNumber";

    private void Awake()
    {
    }

    private void Start()
    {
        ShowUsersGold();
        // Cargar valores desde PlayerPrefs al inicio
        if (PlayerPrefs.HasKey(playerPrefsKey))
        {
            savedNumber = PlayerPrefs.GetFloat(playerPrefsKey);
            RaxxarsavedNumber = PlayerPrefs.GetFloat(RaxxarsavedNumberKey, 0);
            PrometeosavedNumber = PlayerPrefs.GetFloat(PrometeosavedNumberKey, 0);
            KaironsavedNumber = PlayerPrefs.GetFloat(KaironsavedNumberKey, 0);
            BarlemsavedNumber = PlayerPrefs.GetFloat(BarlemsavedNumberKey, 0);
            RagnavaldrsavedNumber = PlayerPrefs.GetFloat(RagnavaldrsavedNumberKey, 0);
            AlmaFellassavedNumber = PlayerPrefs.GetFloat(AlmaFellassavedNumberKey, 0);

            numberText.text = savedNumber.ToString();
        }

        // Cargar valores para cada usuario
        RaxxarsavedNumber = PlayerPrefs.GetFloat(RaxxarsavedNumberKey, 0);
        PrometeosavedNumber = PlayerPrefs.GetFloat(PrometeosavedNumberKey, 0);
        KaironsavedNumber = PlayerPrefs.GetFloat(KaironsavedNumberKey, 0);
        BarlemsavedNumber = PlayerPrefs.GetFloat(BarlemsavedNumberKey, 0);
        RagnavaldrsavedNumber = PlayerPrefs.GetFloat(RagnavaldrsavedNumberKey, 0);
        AlmaFellassavedNumber = PlayerPrefs.GetFloat(AlmaFellassavedNumberKey, 0);

    }

    void Update()
    {
        // Actualizar valores para cada usuario
        if (Anibal == true)
        {
            RaxxarsavedNumber = savedNumber;
        }
        if (Pablo == true)
        {
            PrometeosavedNumber = savedNumber;
        }
        if (Armando == true)
        {
            KaironsavedNumber = savedNumber;
        }
        if (Ruben == true)
        {
            BarlemsavedNumber = savedNumber;
        }
        if (Samuel == true)
        {
            AlmaFellassavedNumber = savedNumber;
        }
        if (Chispo == true)
        {
            RagnavaldrsavedNumber = savedNumber;
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

            PlayerPrefs.Save();

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

        }
        inputField.text = "";
    }


    public void SubtractNumber()
    {
        if (float.TryParse(inputField.text, out float inputNumber))
        {
            savedNumber -= inputNumber;
            numberText.text = savedNumber.ToString();

            PlayerPrefs.SetFloat(playerPrefsKey, savedNumber);
            PlayerPrefs.Save();

        }
        inputField.text = "";
    }

    
    public void ShowUsersGold()
    {
        if (Anibal == true)
        {
            numberText.text = savedNumber.ToString();
        }
        if (Pablo == true)
        {
            numberText.text = savedNumber.ToString();

        }
        if (Armando == true)
        {
            numberText.text = savedNumber.ToString();

        }
        if (Ruben == true)
        {
            numberText.text = savedNumber.ToString();

        }
        if (Samuel == true)
        {
            numberText.text = savedNumber.ToString();

        }
        if (Chispo == true)
        {
            numberText.text = savedNumber.ToString();

        }
    }
    public void SetUsersGold()
    {
        if (Anibal == true)
        {
            savedNumber = RaxxarsavedNumber;
        }
        if (Pablo == true)
        {
            savedNumber = PrometeosavedNumber;

        }
        if (Armando == true)
        {
            savedNumber = KaironsavedNumber;

        }
        if (Ruben == true)
        {
            savedNumber = BarlemsavedNumber;

        }
        if (Samuel == true)
        {
            savedNumber = AlmaFellassavedNumber;

        }
        if (Chispo == true)
        {
            savedNumber = RagnavaldrsavedNumber;

        }
    }
    public void Raxxar()
    {
        Anibal = true;
        Pablo = false;
        Chispo = false;
        Ruben = false;
        Armando = false;
        Samuel = false;
    }
    public void Prometeo()
    {
        Pablo = true;
        Anibal = false;
        Chispo = false;
        Ruben = false;
        Armando = false;
        Samuel = false;
    }
    public void Kairon()
    {
        Armando = true;
        Pablo = false;
        Anibal = false;
        Samuel = false;
        Chispo = false;
        Ruben = false;
    }
    public void Barled()
    {
        Ruben = true;
        Armando = false;
        Pablo = false;
        Anibal = false;
        Samuel = false;
        Chispo = false;
    }
    public void Ragnavaldr()
    {
        Chispo = true;
        Ruben = false;
        Armando = false;
        Pablo = false;
        Anibal = false;
        Samuel = false;
    }
    public void AlmaFellas()
    {
        Samuel = true;
        Chispo = false;
        Ruben = false;
        Armando = false;
        Pablo = false;
        Anibal = false;
    }
}
