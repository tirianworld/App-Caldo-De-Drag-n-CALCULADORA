using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargaFalsa : MonoBehaviour
{
    public int scenetochange;
    public float tiempoDeCarga = 2.0f; // Tiempo en segundos para la carga falsa

    void Start()
    {
        Invoke("CargarEscenaInicial", tiempoDeCarga);
    }

    void CargarEscenaInicial()
    {
        SceneManager.LoadScene(scenetochange); // Carga la escena inicial (escena 0)
    }
}