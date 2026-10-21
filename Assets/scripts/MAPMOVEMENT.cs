using UnityEngine;

public class MAPMOVEMENT : MonoBehaviour
{
    private Vector2 touchStartPos;
    private Vector2 objectStartPos;
    private bool isDragging = false;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touch.position))
                    {
                        // Inicia el arrastre si el toque comienza dentro del collider de la imagen.
                        isDragging = true;
                        touchStartPos = touch.position;
                        objectStartPos = transform.position;
                    }
                    break;

                case TouchPhase.Moved:
                    if (isDragging)
                    {
                        // Calcula la nueva posición de la imagen en función del arrastre.
                        Vector2 delta = touch.position - touchStartPos;
                        transform.position = objectStartPos + delta;
                    }
                    break;

                case TouchPhase.Ended:
                    // Detiene el arrastre cuando se levanta el dedo.
                    isDragging = false;
                    break;
            }
        }
    }
}

