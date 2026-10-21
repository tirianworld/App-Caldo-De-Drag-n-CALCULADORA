using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class KaironSpecial : MonoBehaviour
{
    public Image slider;
    public TextMeshProUGUI number;
    public float valor;

    private string valorKey = "KaironSpecialValor";

    void Start()
    {
        if (PlayerPrefs.HasKey(valorKey))
        {
            valor = PlayerPrefs.GetFloat(valorKey);
        }
    }

    void Update()
    {
        if (valor >= 0 && valor <= 10)
        {
            number.text = valor.ToString();
        }

        float targetFillAmount = valor / 10.0f;
        slider.fillAmount = Mathf.Lerp(slider.fillAmount, targetFillAmount, Time.deltaTime * 5f);
    }

    public void valorplus()
    {
        if (valor >= 0 && valor < 10)
        {
            valor += 1;
            SaveValorToPlayerPrefs();
        }
    }

    public void valorless()
    {
        if (valor > 0 && valor <= 10)
        {
            valor -= 1;
            SaveValorToPlayerPrefs();
        }
    }

    private void SaveValorToPlayerPrefs()
    {
        PlayerPrefs.SetFloat(valorKey, valor);
    }
}
