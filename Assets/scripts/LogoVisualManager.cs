using System.Collections.Generic;
using UnityEngine;

public class LogoVisualManager : MonoBehaviour
{
    private Logos logos;

    [System.Serializable]
    public class LogoVisual
    {
        public string nombre;
        public GameObject objetoVisual;
    }

    public List<LogoVisual> logoVisuales;

    void Start()
    {
        if (logos == null)
        {
            logos = FindObjectOfType<Logos>();
            if (logos == null)
            {
                Debug.LogError("No se encontró ningún componente Logos en la escena.");
                return;
            }
        }

        ActivarLogoVisual();
    }


    void ActivarLogoVisual()
    {
        string activo = ObtenerLogoActivo();

        foreach (var logo in logoVisuales)
        {
            if (logo.nombre == activo)
                logo.objetoVisual.SetActive(true);
            else
                logo.objetoVisual.SetActive(false);
        }
    }

    string ObtenerLogoActivo()
    {
        if (logos.Default) return "Default";
        if (logos.Mercado) return "Mercado";
        if (logos.Omega) return "Omega";
        if (logos.Raxxar) return "Raxxar";
        if (logos.Kairon) return "Kairon";
        if (logos.Alma) return "Alma";
        if (logos.Ragnavaldr) return "Ragnavaldr";
        if (logos.Prometeo) return "Prometeo";
        if (logos.Reloj) return "Reloj";
        if (logos.Tribunal) return "Tribunal";

        return ""; // Ninguno activo
    }

    public void Refrescar()
    {
        ActivarLogoVisual();
    }
}
