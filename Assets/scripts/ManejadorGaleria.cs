using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;


public class ManejadorGaleria : MonoBehaviour
{
    private Inventary cambiarImagenScript; // Referencia al script CambiarImagenBoton

    private void Start()
    {
        // Obtener el componente CambiarImagenBoton adjunto al mismo GameObject
        cambiarImagenScript = GetComponent<Inventary>();

        // Verificar si se tienen permisos de lectura externa al inicio
        if (!Permission.HasUserAuthorizedPermission(Permission.ExternalStorageRead))
        {
            Permission.RequestUserPermission(Permission.ExternalStorageRead);
        }
    }

    // Método que se llama cuando la actividad de selección de imagen finaliza en Android
    public void OnActivityResult(string imagePath)
    {
        // Llamar al método ObtenerImagen del script CambiarImagenBoton pasando la ruta de la imagen seleccionada
        cambiarImagenScript.ObtenerImagen(imagePath);
    }
}
