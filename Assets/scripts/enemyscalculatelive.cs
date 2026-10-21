using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class enemyscalculatelive : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text numberText;
    public GameObject dangerZone;
    public TMP_InputField armourClassInputField;
    public TMP_Text armourClassText;

    public float savedNumber = 0;
    private float armourClass = 0;
    private const string playerPrefsKey = "SavedNumber";

    private void Start()
    {
        if (PlayerPrefs.HasKey(playerPrefsKey))
        {
            savedNumber = PlayerPrefs.GetFloat(playerPrefsKey);
            UpdateNumberText();
        }

    }

    private void UpdateNumberText()
    {
        numberText.text = savedNumber.ToString();
        armourClassText.text = armourClass.ToString();
    }

    public void SaveNumber()
    {
        if (float.TryParse(inputField.text, out float inputNumber))
        {
            savedNumber = inputNumber;
            UpdateNumberText();

            PlayerPrefs.SetFloat(playerPrefsKey, savedNumber);
            PlayerPrefs.Save();
        }
        inputField.text = "";
    }

    public void AddNumber()
    {
        if (float.TryParse(inputField.text, out float inputNumber))
        {
            savedNumber += inputNumber;
            UpdateNumberText();

            CheckDangerZone();

            PlayerPrefs.SetFloat(playerPrefsKey, savedNumber);
            PlayerPrefs.Save();
        }
        inputField.text = "";
    }

    public void SubtractNumber()
    {
        if (float.TryParse(inputField.text, out float inputNumber))
        {
            float result = savedNumber - inputNumber;
            if (result < 0) // Evita que el número sea negativo.
            {
                result = 0;
                savedNumber = result; //  No suma la armour class al resultado.
            }
            else if(result >= 0 && inputNumber >= armourClass)
            {
                savedNumber = result + armourClass; // Suma la armour class al resultado.
            }

            UpdateNumberText();

            CheckDangerZone();

            PlayerPrefs.SetFloat(playerPrefsKey, savedNumber);
            PlayerPrefs.Save();
        }
        inputField.text = "";
    }



    public void UpdateArmourClass()
    {
        
        
        if (float.TryParse(armourClassInputField.text, out float ac))
        {

            armourClass = ac;
            UpdateNumberText();
            armourClassInputField.text = "";
        }
    }

    private void CheckDangerZone()
    {
       
         if (savedNumber <= 0)
        {
            dangerZone.SetActive(false);
        }
    }
}
