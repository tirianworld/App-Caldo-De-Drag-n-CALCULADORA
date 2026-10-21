using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class GMmode : MonoBehaviour
{
    public TMP_InputField inputField;
    public GameObject gmscreen;

    private void Start()
    {
        gmscreen.gameObject.SetActive(false);
    }

    public void Mostrargmscreen()
    {
        gmscreen.gameObject.SetActive(true);
    }
    public void cerrarGmscreen()
    {
        gmscreen.gameObject.SetActive(false);
    }

    public void ComprobarInput()
    {
        string entradaUsuario = inputField.text.Trim();
        if (entradaUsuario.Equals("COMPAÑIA", System.StringComparison.OrdinalIgnoreCase))
        {
            SceneManager.LoadScene(9);
        }
       
    }
}
