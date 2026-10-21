using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FillSprite : MonoBehaviour
{
    public SpriteRenderer[] spritesToFill; // Arreglo de sprites a llenar
    private Vector3[] initialScales; // Almacena las escalas iniciales de cada sprite
    private Vector3[] initialPositions; // Almacena las posiciones locales iniciales de cada sprite
    public float[] fillValues; // Valores de llenado para cada sprite

    void Start()
    {
        // Inicializa el arreglo fillValues con la longitud del número de sprites
        fillValues = new float[spritesToFill.Length];

        // Inicializa el arreglo initialScales con la longitud del número de sprites
        initialScales = new Vector3[spritesToFill.Length];

        // Inicializa el arreglo initialPositions con la longitud del número de sprites
        initialPositions = new Vector3[spritesToFill.Length];

        // Guarda las escalas iniciales y posiciones locales de cada sprite
        for (int i = 0; i < spritesToFill.Length; i++)
        {
            initialScales[i] = spritesToFill[i].transform.localScale;
            initialPositions[i] = spritesToFill[i].transform.localPosition;
        }
    }

    void Update()
    {
        // Asegurar que los valores de llenado están dentro del rango 0-1
        for (int i = 0; i < fillValues.Length; i++)
        {
            fillValues[i] = Mathf.Clamp01(fillValues[i]);
        }

        // Iterar a través de los sprites a llenar
        for (int i = 0; i < spritesToFill.Length; i++)
        {
            // Verificar si el índice es válido en fillValues
            if (i < fillValues.Length)
            {
                // Calcular la escala final teniendo en cuenta la escala inicial y el llenado
                float newScaleX = initialScales[i].x * fillValues[i];

                // Calcular el desplazamiento para que el llenado sea de derecha a izquierda
                float offsetX = (initialScales[i].x - newScaleX) * 0.5f;

                // Calcular la nueva posición local
                float spriteWidth = spritesToFill[i].bounds.size.x;
                float newXPosition = initialPositions[i].x + spriteWidth * 0.5f - offsetX;

                // Actualizar la posición y la escala para simular el llenado de derecha a izquierda
                spritesToFill[i].transform.localScale = new Vector3(newScaleX, initialScales[i].y, initialScales[i].z);
                spritesToFill[i].transform.localPosition = new Vector3(newXPosition, initialPositions[i].y, initialPositions[i].z);
            }
        }
    }
}