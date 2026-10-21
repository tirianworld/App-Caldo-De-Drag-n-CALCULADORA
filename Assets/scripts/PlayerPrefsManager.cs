using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    // Elimina todos los datos guardados en PlayerPrefs
    public static void ClearAllPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();  // Asegúrate de guardar los cambios después de eliminar.
        Debug.Log("Todos los datos de PlayerPrefs han sido eliminados.");
    }

    // Función de ejemplo para llamar a la eliminación
    public static void TestDeleteAll()
    {
        ClearAllPlayerPrefs();
    }
}
