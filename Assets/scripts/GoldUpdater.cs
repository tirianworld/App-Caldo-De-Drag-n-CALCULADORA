using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class GoldUpdater : MonoBehaviour
{
    private string csvUrl = "https://docs.google.com/spreadsheets/d/1sEObsqjLgRhChBbmqlXp_HJ1IiAdJuCBfzf5Sz82Nw0/export?format=csv"; // URL del CSV

    // Referencias al script "gold"
    public gold goldScript;

    private void Start()
    {
        // Asegúrate de que el Gold script esté referenciado
        if (goldScript == null)
        {
            goldScript = GameObject.FindObjectOfType<gold>();
        }
    }

    // Método que se llamará para actualizar los valores de oro
    public void RecargarGold()
    {
        StartCoroutine(LoadCSVDataFromGoogleSheets());
    }

    private IEnumerator LoadCSVDataFromGoogleSheets()
    {
        UnityWebRequest www = UnityWebRequest.Get(csvUrl);
        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.Success)
        {
            string csvContent = www.downloadHandler.text;
            string[] lines = csvContent.Split('\n');

            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    string[] columns = line.Split(',');

                    // Comprobar que la línea tenga tres columnas y que la columna "Oro" sea válida
                    if (columns.Length >= 3)
                    {
                        string user = columns[2].Trim(); // Nombre del usuario
                        float goldAmount;

                        // Validar que el valor de oro es un número válido
                        if (float.TryParse(columns[1].Trim(), out goldAmount))
                        {
                            // Actualizar los valores de oro en el script gold
                            switch (user)
                            {
                                case "Raxxar":
                                    goldScript.RaxxarsavedNumber = goldAmount;
                                    goldScript.savedNumber = goldAmount;
                                    break;
                                case "Prometeo":
                                    goldScript.PrometeosavedNumber = goldAmount;
                                    goldScript.savedNumber = goldAmount;

                                    break;
                                case "Kairon":
                                    goldScript.KaironsavedNumber = goldAmount;
                                    goldScript.savedNumber = goldAmount;

                                    break;
                                case "Barlem":
                                    goldScript.BarlemsavedNumber = goldAmount;
                                    goldScript.savedNumber = goldAmount;

                                    break;
                                case "Ragnavaldr":
                                    goldScript.RagnavaldrsavedNumber = goldAmount;
                                    goldScript.savedNumber = goldAmount;

                                    break;
                                case "AlmaFellas":
                                    goldScript.AlmaFellassavedNumber = goldAmount;
                                    goldScript.savedNumber = goldAmount;

                                    break;
                                case "PepeLouy":
                                    goldScript.PepeLouysavedNumber = goldAmount;
                                                                        goldScript.savedNumber = goldAmount;

                                    break;
                            }
                        }
                    }
                }
            }

            // Guardar los cambios y actualizar la UI
            goldScript.UpdateGoldDependentObjectsVisibility();
            goldScript.ShowUsersGold();
        }
        else
        {
            Debug.LogError("Error al obtener el CSV desde Google Sheets: " + www.error);
        }
    }
}
