using UnityEngine;

public class audiosource : MonoBehaviour
{
    // Referencia al componente de audio
    public AudioSource clickboton;

    // Función para reproducir el audio
    public void ReproducirAudio()
    {
        if (clickboton != null)
        {
            clickboton.Play();
        }
    }
}
