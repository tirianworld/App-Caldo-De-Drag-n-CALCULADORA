using UnityEngine;

public class GuardarTransform : MonoBehaviour
{
    // Identificador único para esta instancia
    public string instanciaID;

    void Start()
    {
        // Genera un ID único si no se ha asignado uno
        if (string.IsNullOrEmpty(instanciaID))
        {
            instanciaID = System.Guid.NewGuid().ToString();
        }

        // Opcional: Cargar la posición, rotación y escala al iniciar el juego
        CargarTransform();
    }
    private void OnApplicationQuit()
    {
        GuardarTransformP();
    }
    // Método para guardar el transform del objeto
    public void GuardarTransformP()
    {
        PlayerPrefs.SetFloat(instanciaID + "_PosX", transform.position.x);
        PlayerPrefs.SetFloat(instanciaID + "_PosY", transform.position.y);
        PlayerPrefs.SetFloat(instanciaID + "_PosZ", transform.position.z);

        PlayerPrefs.SetFloat(instanciaID + "_RotX", transform.rotation.eulerAngles.x);
        PlayerPrefs.SetFloat(instanciaID + "_RotY", transform.rotation.eulerAngles.y);
        PlayerPrefs.SetFloat(instanciaID + "_RotZ", transform.rotation.eulerAngles.z);

        PlayerPrefs.SetFloat(instanciaID + "_ScaleX", transform.localScale.x);
        PlayerPrefs.SetFloat(instanciaID + "_ScaleY", transform.localScale.y);
        PlayerPrefs.SetFloat(instanciaID + "_ScaleZ", transform.localScale.z);

        PlayerPrefs.Save();
    }

    // Método para cargar el transform del objeto
    public void CargarTransform()
    {
        if (PlayerPrefs.HasKey(instanciaID + "_PosX"))
        {
            float posX = PlayerPrefs.GetFloat(instanciaID + "_PosX");
            float posY = PlayerPrefs.GetFloat(instanciaID + "_PosY");
            float posZ = PlayerPrefs.GetFloat(instanciaID + "_PosZ");
            transform.position = new Vector3(posX, posY, posZ);

            float rotX = PlayerPrefs.GetFloat(instanciaID + "_RotX");
            float rotY = PlayerPrefs.GetFloat(instanciaID + "_RotY");
            float rotZ = PlayerPrefs.GetFloat(instanciaID + "_RotZ");
            transform.rotation = Quaternion.Euler(rotX, rotY, rotZ);

            float scaleX = PlayerPrefs.GetFloat(instanciaID + "_ScaleX");
            float scaleY = PlayerPrefs.GetFloat(instanciaID + "_ScaleY");
            float scaleZ = PlayerPrefs.GetFloat(instanciaID + "_ScaleZ");
            transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        }
    }
}