using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logos : MonoBehaviour
{
    public bool Default = false;
    public bool Mercado = false;
    public bool Omega = false;
    public bool Raxxar = false;
    public bool Kairon = false;
    public bool Alma = false;
    public bool Ragnavaldr = false;
    public bool Prometeo = false;
    public bool Reloj = false;
    public bool Tribunal = false;
    private LogoVisualManager LVM;

     void Update()
    {
        if (LVM == null)
        {
            LVM = FindObjectOfType<LogoVisualManager>();
            LVM.Refrescar();

            if (LVM == null)
            {
                Debug.LogError("No se encontró ningún componente Logos en la escena.");
                return;
            }
        }
    }
    public void SeleccionarLogo(string nombre)
    {
        Default = false;
        Mercado = false;
        Omega = false;
        Raxxar = false;
        Kairon = false;
        Alma = false;
        Ragnavaldr = false;
        Prometeo = false;
        Reloj = false;
        Tribunal = false;

        switch (nombre)
        {
            case "Default":
                Default = true;
                break;
            case "Mercado":
                Mercado = true;
                break;
            case "Omega":
                Omega = true;
                break;
            case "Raxxar":
                Raxxar = true;
                break;
            case "Kairon":
                Kairon = true;
                break;
            case "Alma":
                Alma = true;
                break;
            case "Ragnavaldr":
                Ragnavaldr = true;
                break;
            case "Prometeo":
                Prometeo = true;
                break;
            case "Reloj":
                Reloj = true;
                break;
            case "Tribunal":
                Tribunal = true;
                break;
            default:
                Debug.LogWarning("Nombre de logo no reconocido: " + nombre);
                break;
        }
    }





}
