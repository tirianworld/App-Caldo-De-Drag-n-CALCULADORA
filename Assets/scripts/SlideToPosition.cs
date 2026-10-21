using UnityEngine;
using DG.Tweening;

public class SlideToPosition : MonoBehaviour
{
    [Header("Configuración general")]
    public bool usarCoordenadasCanvas = false; // Activa si el objeto es UI (RectTransform)
    public float duracion = 1.5f;
    public Ease tipoDeDeslizamiento = Ease.OutQuad;

    [Header("Objeto a desplazar")]
    public GameObject objetoADesplazar;

    [Header("Destino")]
    public Vector3 posicionFinal;

    /// <summary>
    /// Mueve el objeto a una nueva posición, ya sea en coordenadas de mundo o UI.
    /// </summary>
    public void MoverHacia(Vector3 nuevaPosicion)
    {
        if (usarCoordenadasCanvas && objetoADesplazar.TryGetComponent(out RectTransform rectTransform))
        {
            // Movimiento en UI (Canvas) usando anchoredPosition
            rectTransform.DOAnchorPos((Vector2)nuevaPosicion, duracion).SetEase(tipoDeDeslizamiento);
        }
        else
        {
            // Movimiento en mundo 3D
            objetoADesplazar.transform.DOMove(nuevaPosicion, duracion).SetEase(tipoDeDeslizamiento);
        }
    }

    /// <summary>
    /// Mueve directamente a la posición final definida en el inspector.
    /// </summary>
    public void Mover()
    {
        MoverHacia(posicionFinal);
    }
}
