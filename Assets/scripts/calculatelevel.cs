using UnityEngine;
using TMPro;

public class calculatelevel : MonoBehaviour
{
    public TMP_Dropdown claseDropdown;
    public TMP_InputField nivelInput;
    public TMP_InputField ExtraLife;
    public TMP_Text resultadoTMP;
    public TMP_Text zonaCriticaTMP;

    public struct ClaseHP
    {
        public string nombre;
        public int hpBaseNivel1;
        public int hpBaseNivel10;
        public int hpIncrementoNiveles1to10;
        public int hpIncrementoNiveles11to20;
    }

    public ClaseHP[] clases;

    private void Start()
    {
        clases = new ClaseHP[]
         {
            new ClaseHP { nombre = "Barbáro", hpBaseNivel1 = 20, hpBaseNivel10 = 110, hpIncrementoNiveles1to10 = 10 , hpIncrementoNiveles11to20 = 15 },
            new ClaseHP { nombre = "Bardo", hpBaseNivel1 = 10, hpBaseNivel10 = 55, hpIncrementoNiveles1to10 = 5, hpIncrementoNiveles11to20 = 7 },
            new ClaseHP { nombre = "Brujo", hpBaseNivel1 = 12, hpBaseNivel10 = 66, hpIncrementoNiveles1to10 = 6, hpIncrementoNiveles11to20 = 8 },
            new ClaseHP { nombre = "Clérigo", hpBaseNivel1 = 12, hpBaseNivel10 = 66, hpIncrementoNiveles1to10 = 6, hpIncrementoNiveles11to20 = 8 },
            new ClaseHP { nombre = "Druida", hpBaseNivel1 = 11, hpBaseNivel10 = 65, hpIncrementoNiveles1to10 = 6, hpIncrementoNiveles11to20 = 8 },
            new ClaseHP { nombre = "Explorador", hpBaseNivel1 = 11, hpBaseNivel10 = 56, hpIncrementoNiveles1to10 = 5, hpIncrementoNiveles11to20 = 7 },
            new ClaseHP { nombre = "Guerrero", hpBaseNivel1 = 18, hpBaseNivel10 = 90, hpIncrementoNiveles1to10 = 8, hpIncrementoNiveles11to20 = 12 },
            new ClaseHP { nombre = "Hechicero", hpBaseNivel1 = 10, hpBaseNivel10 = 55, hpIncrementoNiveles1to10 = 5, hpIncrementoNiveles11to20 = 7 },
            new ClaseHP { nombre = "Mago", hpBaseNivel1 = 12, hpBaseNivel10 = 66, hpIncrementoNiveles1to10 = 6, hpIncrementoNiveles11to20 = 8 },
            new ClaseHP { nombre = "Monje", hpBaseNivel1 = 15, hpBaseNivel10 = 78, hpIncrementoNiveles1to10 = 7, hpIncrementoNiveles11to20 = 10 },
            new ClaseHP { nombre = "Pladín", hpBaseNivel1 = 16, hpBaseNivel10 = 88, hpIncrementoNiveles1to10 = 8, hpIncrementoNiveles11to20 = 12 },
            new ClaseHP { nombre = "Pícaro", hpBaseNivel1 = 12, hpBaseNivel10 = 57, hpIncrementoNiveles1to10 = 5, hpIncrementoNiveles11to20 = 7 },
            new ClaseHP { nombre = "Bloodhunter", hpBaseNivel1 = 16, hpBaseNivel10 = 88, hpIncrementoNiveles1to10 = 8, hpIncrementoNiveles11to20 = 12 },
            new ClaseHP { nombre = "Shaman", hpBaseNivel1 = 13, hpBaseNivel10 = 58, hpIncrementoNiveles1to10 = 5, hpIncrementoNiveles11to20 = 7 },
            new ClaseHP { nombre = "Blackguard", hpBaseNivel1 = 19, hpBaseNivel10 = 100, hpIncrementoNiveles1to10 = 9, hpIncrementoNiveles11to20 = 13 },
            new ClaseHP { nombre = "Artificiero", hpBaseNivel1 = 11, hpBaseNivel10 = 56, hpIncrementoNiveles1to10 = 5, hpIncrementoNiveles11to20 = 7 },

             // más clases aquí...
         };

        foreach (var clase in clases)
        {
            claseDropdown.options.Add(new TMP_Dropdown.OptionData(clase.nombre));
        }
    }

    public void CalcularHP()
    {
        int nivel ;
        if (!int.TryParse(nivelInput.text, out nivel))
        {
            resultadoTMP.text = "Ingresa un nivel válido.";
            return;
        }

        int claseIndex = claseDropdown.value;
        if (claseIndex < 0 || claseIndex >= clases.Length)
        {
            resultadoTMP.text = "Selecciona una clase válida.";
            return;
        }

        int hpTotal;
        if (nivel <= 10)
        {
            hpTotal = clases[claseIndex].hpBaseNivel1 + (clases[claseIndex].hpIncrementoNiveles1to10 * (nivel - 1));
        }
        else if (nivel <= 20)
        {
            int nivel10HP = clases[claseIndex].hpBaseNivel1 + (clases[claseIndex].hpIncrementoNiveles1to10 * 9);
            hpTotal = nivel10HP + (clases[claseIndex].hpIncrementoNiveles11to20 * (nivel - 10));
        }
        else
        {
            resultadoTMP.text = "Nivel máximo es 20.";
            return;
        }

        resultadoTMP.text = "HP total: " + hpTotal.ToString();
    }

    public int CalcularZonaCritica(int nivel, int hpTotal)
    {
        double zonaCritica = hpTotal * 0.2; // Calcula el 20% de la vida total
        int zonaCriticaRedondeada = Mathf.RoundToInt((float)zonaCritica); // Redondea al entero más cercano

        return zonaCriticaRedondeada;
    }

    public void CalcularZonaCriticaClick()
    {
        int nivel;
        if (!int.TryParse(nivelInput.text, out nivel))
        {
            zonaCriticaTMP.text = "Ingresa un nivel válido.";
            return;
        }

        int claseIndex = claseDropdown.value;
        if (claseIndex < 0 || claseIndex >= clases.Length)
        {
            zonaCriticaTMP.text = "Selecciona una clase válida.";
            return;
        }

        int hpTotal;
        if (nivel <= 10)
        {
            hpTotal = clases[claseIndex].hpBaseNivel1 + (clases[claseIndex].hpIncrementoNiveles1to10 * (nivel - 1));
        }
        else if (nivel <= 20)
        {
            int nivel10HP = clases[claseIndex].hpBaseNivel1 + (clases[claseIndex].hpIncrementoNiveles1to10 * 9);
            hpTotal = nivel10HP + (clases[claseIndex].hpIncrementoNiveles11to20 * (nivel - 10));
        }
        else
        {
            zonaCriticaTMP.text = "Nivel máximo es 20.";
            return;
        }

        int zonaCritica = CalcularZonaCritica(nivel, hpTotal);
        zonaCriticaTMP.text = "Zona de peligro: " + zonaCritica.ToString();
    }
    public void SumarExtraLife()
    {
        int extraLifeValue;
        if (!int.TryParse(ExtraLife.text, out extraLifeValue))
        {
            resultadoTMP.text = "Ingresa un valor válido para Vida Extra.";
            return;
        }

        int nivel;
        if (!int.TryParse(nivelInput.text, out nivel))
        {
            resultadoTMP.text = "Ingresa un nivel válido.";
            return;
        }

        int claseIndex = claseDropdown.value;
        if (claseIndex < 0 || claseIndex >= clases.Length)
        {
            resultadoTMP.text = "Selecciona una clase válida.";
            return;
        }

        int hpTotal;
        if (nivel <= 10)
        {
            hpTotal = clases[claseIndex].hpBaseNivel1 + (clases[claseIndex].hpIncrementoNiveles1to10 * (nivel - 1));
        }
        else if (nivel <= 20)
        {
            int nivel10HP = clases[claseIndex].hpBaseNivel1 + (clases[claseIndex].hpIncrementoNiveles1to10 * 9);
            hpTotal = nivel10HP + (clases[claseIndex].hpIncrementoNiveles11to20 * (nivel - 10));
        }
        else
        {
            resultadoTMP.text = "Nivel máximo es 20.";
            return;
        }

        // Sumar Extra Life al HP total obtenido en CalcularHP
        int hpTotalConExtraLife = hpTotal + extraLifeValue;

        resultadoTMP.text = "HP total con Vida Extra: " + hpTotalConExtraLife.ToString();
    }

}