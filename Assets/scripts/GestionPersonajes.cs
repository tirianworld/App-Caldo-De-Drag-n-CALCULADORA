using UnityEngine;
using TMPro;

[System.Serializable]
public class Personaje
{
    public string nombre;
    public int claseIndex;
    public int nivel;
    public int hpTotal;
}

public class GestionPersonajes : MonoBehaviour
{
    public TMP_InputField nombreInput;
    public TMP_Text personajeGuardadoTMP;
    public calculatelevel calculadora; // Referencia al script CalculateLevel

    private Personaje personajeActual;

    public TMP_Dropdown claseDropdown; // Agregar esta línea para la referencia al Dropdown
    public TMP_Text resultadoTMP; // Agregar esta línea para la referencia al Text

    private calculatelevel calculadoraLevel; // Agregar esta línea para la referencia a CalculateLevel

    private void Start()
    {
        calculadoraLevel = GetComponent<calculatelevel>(); // Obtener la referencia a CalculateLevel
    }

    public void GuardarPersonaje()
    {
        personajeActual = new Personaje
        {
            nombre = nombreInput.text,
            claseIndex = claseDropdown.value,
            nivel = int.Parse(calculadoraLevel.nivelInput.text),
            hpTotal = int.Parse(resultadoTMP.text.Split(':')[1].Trim())
        };

        // Guardar el personaje utilizando PlayerPrefs o una base de datos, por ejemplo
        PlayerPrefs.SetString("PersonajeGuardado", JsonUtility.ToJson(personajeActual));
        PlayerPrefs.Save();
        print("saved");
    }

    public void CargarPersonaje()
    {
        // Cargar el personaje guardado desde PlayerPrefs
        string json = PlayerPrefs.GetString("PersonajeGuardado");
        if (!string.IsNullOrEmpty(json))
        {
            personajeActual = JsonUtility.FromJson<Personaje>(json);
            MostrarPersonajeGuardado();
        }
        else
        {
            personajeGuardadoTMP.text = "No hay personaje guardado.";
        }
    }

    public void MostrarPersonajeGuardado()
    {
        if (personajeActual != null)
        {
            personajeGuardadoTMP.text = $"Nombre: {personajeActual.nombre}\nClase: {calculadoraLevel.clases[personajeActual.claseIndex].nombre}\nNivel: {personajeActual.nivel}\nHP: {personajeActual.hpTotal}";
        }
        else
        {
            personajeGuardadoTMP.text = "No hay personaje guardado.";
        }
    }

    public void SubirNivel()
    {
        if (personajeActual != null)
        {
            personajeActual.nivel++;
            calculadoraLevel.CalcularHP(); // Llama a la función CalcularHP del script CalculateLevel
            GuardarPersonaje();
            MostrarPersonajeGuardado();
        }
        else
        {
            personajeGuardadoTMP.text = "No hay personaje guardado.";
        }
    }
}
