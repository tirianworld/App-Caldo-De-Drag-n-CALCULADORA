using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlImagenes : MonoBehaviour
{
    public GameObject[] imagenes; // Array de GameObjects para tus imágenes
    public float tiempoDeCambio = 1.0f; // Tiempo entre cambios de imágenes en segundos
    private int indiceActual = 0; // Índice de la imagen actual

    private void Start()
    {
        // Inicia el bucle de cambio de imágenes
        InvokeRepeating("CambiarImagen", 0, tiempoDeCambio);
    }

    private void CambiarImagen()
    {
        // Desactiva la imagen actual
        imagenes[indiceActual].SetActive(false);

        // Incrementa el índice
        indiceActual++;

        // Si el índice es mayor o igual al número de imágenes, reinícialo a 0
        if (indiceActual >= imagenes.Length)
        {
            indiceActual = 0;
        }

        // Activa la nueva imagen
        imagenes[indiceActual].SetActive(true);
    }
}
