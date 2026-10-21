using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Android;

public class Inventary : MonoBehaviour
{
    public Button boton;
    private Texture2D texturaSeleccionada;

    // Método que se ejecuta al hacer clic en el botón
    public void CambiarImagen()
    {
        // Verificar permiso de lectura externa para Android
        if (!Permission.HasUserAuthorizedPermission(Permission.ExternalStorageRead))
        {
            Permission.RequestUserPermission(Permission.ExternalStorageRead);
        }
        else
        {
            // Abrir el explorador de archivos para seleccionar una imagen
            StartCoroutine(SeleccionarImagen());
        }
    }

    // Coroutine para abrir el explorador de archivos y seleccionar una imagen
    private IEnumerator SeleccionarImagen()
    {
        // Esperar un frame para evitar problemas con la UI
        yield return null;

        // Crear un intent para abrir el explorador de archivos
        AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
        AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
        intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_GET_CONTENT"));
        intentObject.Call<AndroidJavaObject>("setType", "image/*");

        // Obtener el contexto de la aplicación
        AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");

        // Iniciar la actividad para seleccionar la imagen
        AndroidJavaObject result = intentClass.CallStatic<AndroidJavaObject>("createChooser", intentObject, "Seleccionar imagen");
        currentActivity.Call("startActivityForResult", result, 0);
    }

    // Método que se llama cuando se selecciona una imagen desde la galería
    public void ObtenerImagen(string imagePath)
    {
        // Cargar la imagen seleccionada como textura
        if (File.Exists(imagePath))
        {
            byte[] fileData = File.ReadAllBytes(imagePath);
            texturaSeleccionada = new Texture2D(2, 2);
            texturaSeleccionada.LoadImage(fileData);

            // Cambiar la imagen del botón por la imagen seleccionada
            boton.image.sprite = Sprite.Create(texturaSeleccionada, new Rect(0, 0, texturaSeleccionada.width, texturaSeleccionada.height), new Vector2(0.5f, 0.5f));
        }
    }
}
