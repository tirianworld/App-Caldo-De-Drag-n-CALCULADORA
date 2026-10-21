using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterial : MonoBehaviour
{
    public Material newMaterial; // Asigna el material en el Inspector
    private Image uiImage;

    void Start()
    {
        // Obtener el componente Image del objeto UI
        uiImage = GetComponent<Image>();

        // Cambiar el material
        if (uiImage != null)
        {
            uiImage.material = newMaterial;
        }
    }
}
