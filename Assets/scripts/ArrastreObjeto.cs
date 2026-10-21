using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ArrastreObjeto : MonoBehaviour
{
    public bool DragActive;
    public Vector2 screenposition;
    private Vector3 WorldPosition;
    public Arrastrable ultimoarrastrable;
    public float smoothness = 5f; // Ajusta la suavidad del movimiento

    void Awake()
    {
        ArrastreObjeto[] controlers = FindObjectsOfType<ArrastreObjeto>();
        if (controlers.Length > 1)
        {
            Destroy(gameObject);
        }

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
            screenposition = new Vector2(mousePos.x, mousePos.y);
        }
        else if (Input.touchCount > 0)
        {
            screenposition = Input.GetTouch(0).position;
        }
        else
        {
            return;
        }

        WorldPosition = Camera.main.ScreenToWorldPoint(screenposition);

        if (DragActive)
        {
            Drag();
        }
        else
        {
            RaycastHit2D hit = Physics2D.Raycast(WorldPosition, Vector2.zero);
            if (hit.collider != null)
            {
                Arrastrable arrastrable = hit.transform.gameObject.GetComponent<Arrastrable>();
                if (arrastrable != null)
                {
                    ultimoarrastrable = arrastrable;
                    InitDrag();
                }
            }
        }
    }

    public void InitDrag()
    {
        DragActive = true;
    }

    public void Drag()
    {
        // Usamos Lerp para suavizar el movimiento
        ultimoarrastrable.transform.position = Vector2.Lerp(ultimoarrastrable.transform.position, new Vector2(WorldPosition.x, WorldPosition.y), Time.deltaTime * smoothness);
    }

    public void Drop()
    {
        DragActive = false;
        // Guardar la posición al soltar el objeto
        SavePosition();
    }

    private void SavePosition()
    {
        if (ultimoarrastrable != null)
        {
            PlayerPrefs.SetFloat("arrastrable_x", ultimoarrastrable.transform.position.x);
            PlayerPrefs.SetFloat("arrastrable_y", ultimoarrastrable.transform.position.y);
            PlayerPrefs.Save();
        }
    }

    private void LoadPosition()
    {
        if (ultimoarrastrable != null)
        {
            float x = PlayerPrefs.GetFloat("arrastrable_x", ultimoarrastrable.transform.position.x);
            float y = PlayerPrefs.GetFloat("arrastrable_y", ultimoarrastrable.transform.position.y);
            ultimoarrastrable.transform.position = new Vector2(x, y);
        }
    }
}
