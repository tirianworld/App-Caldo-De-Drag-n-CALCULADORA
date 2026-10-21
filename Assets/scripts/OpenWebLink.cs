using System.Collections;
using UnityEngine;

public class OpenWebLink : MonoBehaviour
{
    // URL que quieres abrir
    public string url = "https://www.spellbookdnd.com/es/characters";

    // Método para abrir el enlace al presionar un botón o al iniciar
    void Start()
    {
     
    }

    // También puedes agregar un método que se llame cuando el jugador presione un botón, por ejemplo:
    public void OpenLinkOnButtonPress()
    {
        LightWebviewAndroid.instance.open(url, LightWebviewAndroid.CloseMode.back);
    }
}
