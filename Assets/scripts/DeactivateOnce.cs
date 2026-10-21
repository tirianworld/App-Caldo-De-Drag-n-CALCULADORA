using UnityEngine;

public class DeactivateOnce : MonoBehaviour
{
    // El nombre de la clave para PlayerPrefs
    private string deactivateKey = "GameObjectDeactivated";

    void Start()
    {
        // Verificamos si el GameObject ya ha sido desactivado
        if (PlayerPrefs.GetInt(deactivateKey, 0) == 1)
        {
            // Si ya ha sido desactivado antes, lo desactivamos
            gameObject.SetActive(false);
        }
    }

    public void Close()
    {
        // Desactivamos el GameObject
        gameObject.SetActive(false);

        // Guardamos en PlayerPrefs que el GameObject ha sido desactivado
        PlayerPrefs.SetInt(deactivateKey, 1);

        // Guardamos los cambios en PlayerPrefs
        PlayerPrefs.Save();
    }
}
