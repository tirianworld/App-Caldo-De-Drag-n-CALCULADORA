using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NoNegativeNumbers : MonoBehaviour
{
    public TMP_InputField inputField;

    private void Start()
    {
        if (inputField == null)
        {
            Debug.LogError("No se ha asignado un InputField en el Inspector.");
            return;
        }

        inputField.onEndEdit.AddListener(ValidateInput);
    }

    private void ValidateInput(string inputText)
    {
        if (decimal.TryParse(inputText, out decimal inputValue))
        {
            if (inputValue < 0)
            {
               
                inputField.text = "1";
            }
        }
        else
        {
            // Si el texto no se puede convertir a un número, restablece el valor a cero
            inputField.text = "1";
        }
    }
}
