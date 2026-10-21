using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DropdownJuiceEffect : MonoBehaviour
{
    [Header("Juice Settings")]
    public float openDuration = 0.3f; // Duración de la animación de apertura
    public float scaleAmount = 1.2f;  // Factor de escala al abrir
    public Ease easeType = Ease.OutBack;  // Tipo de easing para la animación

    private void Start()
    {
        // Buscar todos los Dropdowns en la escena
        Dropdown[] dropdowns = FindObjectsOfType<Dropdown>();

        foreach (var dropdown in dropdowns)
        {
            // Asignar el efecto a cada dropdown
            AssignJuiceEffect(dropdown);
        }
    }

    private void AssignJuiceEffect(Dropdown dropdown)
    {
        // Añadir listener para cuando el valor del Dropdown cambie (cuando el jugador interactúa con él)
        dropdown.onValueChanged.AddListener(delegate {
            AnimateDropdown(dropdown);
        });
    }

    private void AnimateDropdown(Dropdown dropdown)
    {
        // Aplicar el efecto de animación usando DOTween (escala)
        dropdown.transform.DOScale(scaleAmount, openDuration).SetEase(easeType);
    }
}
