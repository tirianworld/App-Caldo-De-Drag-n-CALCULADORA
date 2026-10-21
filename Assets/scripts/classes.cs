using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class classes : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public List<string> clasesDND5E;
    public List<GameObject> objetosClase; // Asigna tus GameObjects en el inspector

    void Start()
    {
        // Inicializa la lista de clases de D&D 5e
        clasesDND5E = new List<string>
        {
            "Barbáro",
            "Bardo",
            "Brujo",
            "Clérigo",
            "Druida",
            "Explorador",
            "Guerrero",
            "Hechicero",
            "Mago",
            "Monje",
            "Paladín",
            "Pícaro",
            "Bloodhunter",
            "Shaman",
            "Blackguard",
            "Artificiero",
        };

        // Asigna la lista de clases al dropdown
        dropdown.AddOptions(clasesDND5E);
    }

    public void DropdownValueChanged(TMP_Dropdown change)
    {
        // Desactiva todos los objetos primero
        foreach (GameObject obj in objetosClase)
        {
            obj.SetActive(false);
        }

        // Activa el GameObject correspondiente a la clase seleccionada
        int claseSeleccionadaIndex = change.value;
        if (claseSeleccionadaIndex >= 0 && claseSeleccionadaIndex < objetosClase.Count)
        {
            objetosClase[claseSeleccionadaIndex].SetActive(true);
        }
    }
    public void AbrirClaseSeleccionada()
{
    // Activa el GameObject correspondiente a la clase seleccionada
    int claseSeleccionadaIndex = dropdown.value;
    if (claseSeleccionadaIndex >= 0 && claseSeleccionadaIndex < objetosClase.Count)
    {
        foreach (GameObject obj in objetosClase)
        {
            obj.SetActive(false);
        }
        objetosClase[claseSeleccionadaIndex].SetActive(true);
    }
}
}
