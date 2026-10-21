using UnityEngine;
using TMPro;
using System.Linq;
using System.Collections.Generic;

public class CalculateAbilities : MonoBehaviour
{
    public TMP_Dropdown classDropdown;
    public TMP_Dropdown subclassDropdown;
    public TMP_Text abilitiesText;

    private Dictionary<string, Dictionary<string, List<string>>> classSubclassAbilities;

    private void Start()
    {
        classSubclassAbilities = new Dictionary<string, Dictionary<string, List<string>>>();

        // Llena el diccionario con las habilidades disponibles para cada clase y subclase
        // Ejemplo de datos:
        AddClassSubclassAbilities("Guerrero", "Campeón", new List<string> { "Habilidad 1", "Habilidad 2" });
        AddClassSubclassAbilities("Guerrero", "Espadachín", new List<string> { "Habilidad 3", "Habilidad 4" });

        // Agrega más datos de habilidades aquí...

        // Llena el dropdown de clases
        classDropdown.ClearOptions();
        classDropdown.AddOptions(classSubclassAbilities.Keys.ToList());
    }


    private void AddClassSubclassAbilities(string className, string subclassName, List<string> abilities)
    {
        if (!classSubclassAbilities.ContainsKey(className))
        {
            classSubclassAbilities[className] = new Dictionary<string, List<string>>();
        }

        classSubclassAbilities[className][subclassName] = abilities;
    }

    public void OnClassSelected()
    {
        string selectedClass = classDropdown.options[classDropdown.value].text;

        if (classSubclassAbilities.ContainsKey(selectedClass))
        {
            // Llena el dropdown de subclases con las subclases disponibles para la clase seleccionada
            Dictionary<string, List<string>> subclassAbilities = classSubclassAbilities[selectedClass];
            List<string> availableSubclasses = new List<string>(subclassAbilities.Keys);
            subclassDropdown.ClearOptions();
            subclassDropdown.AddOptions(availableSubclasses);
        }
        else
        {
            // Si no se encontraron subclases para la clase seleccionada, limpia el dropdown de subclases
            subclassDropdown.ClearOptions();
        }
    }

    public void ShowAbilities()
    {
        string selectedClass = classDropdown.options[classDropdown.value].text;
        string selectedSubclass = subclassDropdown.options[subclassDropdown.value].text;

        if (classSubclassAbilities.ContainsKey(selectedClass) &&
            classSubclassAbilities[selectedClass].ContainsKey(selectedSubclass))
        {
            // Encuentra las habilidades disponibles para la clase y subclase seleccionadas
            List<string> abilities = classSubclassAbilities[selectedClass][selectedSubclass];
            abilitiesText.text = "Habilidades disponibles:\n";

            foreach (string ability in abilities)
            {
                abilitiesText.text += ability + "\n";
            }
        }
        else
        {
            // Si no se encontraron habilidades para la clase o subclase seleccionada, muestra un mensaje de error
            abilitiesText.text = "No se encontraron habilidades para la clase o subclase seleccionada.";
        }
    }
}
