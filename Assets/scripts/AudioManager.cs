using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Este es un patrón de diseño Singleton para asegurarnos de que solo haya una instancia de AudioManager.
    private static AudioManager instance;
    public static AudioManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<AudioManager>();
                if (instance == null)
                {
                    GameObject audioManagerObject = new GameObject("AudioManager");
                    instance = audioManagerObject.AddComponent<AudioManager>();
                }
            }
            return instance;
        }
    }

    private AudioSource audioSource;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        // Añade un componente AudioSource al objeto AudioManager
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    // Función para reproducir el audio
    public void ReproducirAudio(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
