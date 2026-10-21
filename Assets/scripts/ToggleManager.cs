using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToggleManager : MonoBehaviour
{
    public Toggle lacapital; 
    public Image completedlacapital;

     void Start()
    {
        bool toggleState = PlayerPrefs.GetInt("ToggleState", 0) == 1;
        lacapital.isOn = toggleState;

        lacapital.onValueChanged.AddListener(OnToggleValueChanged);

        completedlacapital.gameObject.SetActive(lacapital.isOn);
    }

    private void OnToggleValueChanged(bool newValue)
    {
        int toggleValue = newValue ? 1 : 0;
        PlayerPrefs.SetInt("ToggleState", toggleValue);
        PlayerPrefs.Save(); 

        completedlacapital.gameObject.SetActive(newValue);
    }
}