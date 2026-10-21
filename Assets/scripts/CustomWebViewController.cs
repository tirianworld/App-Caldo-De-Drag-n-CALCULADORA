using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomWebViewController : MonoBehaviour
{
    // Asume que ya tienes un objeto WebView en el GameObject
    public WebViewObject webViewObject;

    // Método para activar o desactivar el WebView
    public void ToggleWebView(bool showWebView)
    {
        if (showWebView)
        {
            // Hacer visible el WebView
            webViewObject.SetVisibility(true);
            // Reanudar el WebView
            webViewObject.Resume();
        }
        else
        {
            // Hacer invisible el WebView
            webViewObject.SetVisibility(false);
            // Pausar el WebView
            webViewObject.Pause();
        }
    }
}
