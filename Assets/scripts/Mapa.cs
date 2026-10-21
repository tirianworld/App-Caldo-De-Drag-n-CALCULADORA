using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mapa : MonoBehaviour
{
    public Image Lacapital;
    private bool lacapitalactivated = false;

    void Start()
    {
        Lacapital.gameObject.SetActive(false);
    }

    public void toggleLacapital()
    {
        lacapitalactivated = !lacapitalactivated;
        Lacapital.gameObject.SetActive(lacapitalactivated);
    }
    public void background()
    {
        if(lacapitalactivated == true)
        {
            Lacapital.gameObject.SetActive(false);
            lacapitalactivated = false;

        }
    }
}
