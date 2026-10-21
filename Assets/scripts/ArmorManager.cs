using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class ArmorManager : MonoBehaviour
{
    [Header("Google Sheets URL CSV")]
    public string csvUrl = "https://docs.google.com/spreadsheets/d/1pCY2rFbP3APsricz98yXxSCJs47l8ov_cPibL-9PAlY/export?format=csv";

    [Header("UI Elements")]
    public TMP_Dropdown tipoDropdown;
    public TMP_Dropdown materialDropdown;
    public TextMeshProUGUI bonificadorLigerezaText;
    public TextMeshProUGUI bonificadorResistenciaText;
    public Button calcularButton;

    private class ArmorData
    {
        public string tipo;
        public string material;
        public float bonificadorLigereza;
        public float bonificadorResistencia;
    }

    private List<ArmorData> armaduras = new List<ArmorData>();

    private void Start()
    {
        calcularButton.onClick.AddListener(CalcularBonificadores);
        StartCoroutine(CargarDatosDesdeSheets());
    }

    private IEnumerator CargarDatosDesdeSheets()
    {
        UnityWebRequest www = UnityWebRequest.Get(csvUrl);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Error al cargar CSV: " + www.error);
            yield break;
        }

        string csvText = www.downloadHandler.text;
        string[] rows = csvText.Split('\n');

        HashSet<string> tipos = new HashSet<string>();
        HashSet<string> materiales = new HashSet<string>();

        for (int i = 1; i < rows.Length; i++) // empieza desde 1 para saltar encabezado
        {
            string[] columns = rows[i].Split(',');

            if (columns.Length < 4) continue;

            ArmorData data = new ArmorData
            {
                tipo = columns[0].Trim(),
                material = columns[1].Trim(),
                bonificadorLigereza = float.Parse(columns[2].Trim()),
                bonificadorResistencia = float.Parse(columns[3].Trim())
            };

            armaduras.Add(data);
            tipos.Add(data.tipo);
            materiales.Add(data.material);
        }

        tipoDropdown.ClearOptions();
        tipoDropdown.AddOptions(new List<string>(tipos));

        materialDropdown.ClearOptions();
        materialDropdown.AddOptions(new List<string>(materiales));
    }

    private void CalcularBonificadores()
    {
        string tipoSeleccionado = tipoDropdown.options[tipoDropdown.value].text;
        string materialSeleccionado = materialDropdown.options[materialDropdown.value].text;

        ArmorData seleccionada = armaduras.Find(a =>
            a.tipo == tipoSeleccionado && a.material == materialSeleccionado);

        if (seleccionada != null)
        {
            bonificadorLigerezaText.text = $"Ligereza: {seleccionada.bonificadorLigereza:+#;-#;0}";
            bonificadorResistenciaText.text = $"Resistencia: {seleccionada.bonificadorResistencia:+#;-#;0}";
        }
        else
        {
            bonificadorLigerezaText.text = "Ligereza: N/A";
            bonificadorResistenciaText.text = "Resistencia: N/A";
        }
    }
}
