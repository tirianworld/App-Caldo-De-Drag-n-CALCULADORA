using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMap : MonoBehaviour
{
    public bool DragActive;
    public Vector2 screenPosition;
    private Vector3 worldPosition;
    private Vector3 initialTouchOffset;
    public float smoothness = 5f; // Ajusta la suavidad del movimiento
    private Camera mainCamera;

    void Awake()
    {
        mainCamera = Camera.main;
        // Cargar la posición guardada si existe
        LoadPosition();
    }

    void Update()
    {
        if (DragActive && (Input.GetMouseButtonUp(0) || (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended)))
        {
            Drop();
            return;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            screenPosition = new Vector2(mousePos.x, mousePos.y);
        }
        else if (Input.touchCount > 0)
        {
            screenPosition = Input.GetTouch(0).position;
        }
        else
        {
            return;
        }

        worldPosition = mainCamera.ScreenToWorldPoint(screenPosition);

        if (DragActive)
        {
            Drag();
        }
        else if (Input.GetMouseButtonDown(0) || (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            // Calcular el offset inicial desde el punto de clic/toque hasta el centro del mapa
            initialTouchOffset = transform.position - worldPosition;
            DragActive = true;
        }
    }

    public void Drag()
    {
        // Usamos Lerp para suavizar el movimiento y aplicamos el offset inicial
        Vector3 targetPosition = new Vector3(worldPosition.x + initialTouchOffset.x, worldPosition.y + initialTouchOffset.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smoothness);
    }

    public void Drop()
    {
        DragActive = false;
        // Guardar la posición al soltar el objeto
        SavePosition();
    }

    private void SavePosition()
    {
        PlayerPrefs.SetFloat("map_x", transform.position.x);
        PlayerPrefs.SetFloat("map_y", transform.position.y);
        PlayerPrefs.Save();
    }

    private void LoadPosition()
    {
        float x = PlayerPrefs.GetFloat("map_x", transform.position.x);
        float y = PlayerPrefs.GetFloat("map_y", transform.position.y);
        transform.position = new Vector2(x, y);
    }
}
