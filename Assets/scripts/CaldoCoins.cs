using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CaldoCoins : MonoBehaviour
{
    public int Caldocoins;
    public TMP_Text CCT;
    public LogIn login;
    public TMP_InputField inputField;


    private const string CaldoCoinsKey = "CaldoCoins";
    private void Awake()
    {
        login = GameObject.Find("Usuary").GetComponent<LogIn>();
        CCT = GameObject.Find("CaldoCointText").GetComponent<TMP_Text>();
    }

    void Start()
    {
        LoadCaldocoins();
        UpdateCaldocoinsUI();
    }

    void Update()
    {
        // This example assumes Caldocoins is updated elsewhere in the code.
        // If Caldocoins is updated in this script, add SaveCaldocoins() wherever Caldocoins changes.
        UpdateCaldocoinsUI();
        
    }
    private void OnApplicationQuit()
    {
        SaveCaldocoins();

    }

    public void AddCoins(int amount)
    {
        Caldocoins += amount;
        UpdateCaldocoinsUI();
    }

    public void SpendCoins(int amount)
    {
        if (Caldocoins >= amount)
        {
            Caldocoins -= amount;
            SaveCaldocoins();
            
        }
    }
    

    private void SaveCaldocoins()
    {
        PlayerPrefs.SetInt(CaldoCoinsKey, Caldocoins);
        PlayerPrefs.Save();
    }

    private void LoadCaldocoins()
    {
        if (PlayerPrefs.HasKey(CaldoCoinsKey))
        {
            Caldocoins = PlayerPrefs.GetInt(CaldoCoinsKey);
        }
        else
        {
            Caldocoins = 0; // Default value if no saved data exists.
        }
    }

    private void UpdateCaldocoinsUI()
    {
        if(CCT != null)
        {
            CCT.text = Caldocoins.ToString();

        }
    }
     public void ComprobarInput()
    {
        if (inputField != null)
        {
            if (login.Jaime == true && login.Anibal == false && login.Pablo == false && login.Armando == false && login.Ruben == false && login.Samuel == false && login.Chispo == false)
            {
                string entradaUsuario = inputField.text.Trim();
                if (entradaUsuario.Equals("1987", System.StringComparison.OrdinalIgnoreCase))
                {
                    AddCoins(1);
                }
            }
            if (login.Jaime == false && login.Anibal == true && login.Pablo == false && login.Armando == false && login.Ruben == false && login.Samuel == false && login.Chispo == false)
            {
                string entradaUsuario = inputField.text.Trim();
                if (entradaUsuario.Equals("3476", System.StringComparison.OrdinalIgnoreCase))
                {
                    AddCoins(1);

                }
            }
            if (login.Jaime == false && login.Anibal == false && login.Pablo == true && login.Armando == false && login.Ruben == false && login.Samuel == false && login.Chispo == false)
            {
                string entradaUsuario = inputField.text.Trim();
                if (entradaUsuario.Equals("9758", System.StringComparison.OrdinalIgnoreCase))
                {
                    AddCoins(1);

                }
            }
            if (login.Jaime == false && login.Anibal == false && login.Pablo == false && login.Armando == true && login.Ruben == false && login.Samuel == false && login.Chispo == false)
            {
                string entradaUsuario = inputField.text.Trim();
                if (entradaUsuario.Equals("4573", System.StringComparison.OrdinalIgnoreCase))
                {
                    AddCoins(1);

                }
            }
            if (login.Jaime == false && login.Anibal == false && login.Pablo == false && login.Armando == false && login.Ruben == true && login.Samuel == false && login.Chispo == false)
            {
                string entradaUsuario = inputField.text.Trim();
                if (entradaUsuario.Equals("2695", System.StringComparison.OrdinalIgnoreCase))
                {
                    AddCoins(1);

                }
            }
            if (login.Jaime == false && login.Anibal == false && login.Pablo == false && login.Armando == false && login.Ruben == false && login.Samuel == true && login.Chispo == false)
            {
                string entradaUsuario = inputField.text.Trim();
                if (entradaUsuario.Equals("8568", System.StringComparison.OrdinalIgnoreCase))
                {
                    AddCoins(1);

                }
            }
            if (login.Jaime == false && login.Anibal == false && login.Pablo == false && login.Armando == false && login.Ruben == false && login.Samuel == false && login.Chispo == true)
            {
                string entradaUsuario = inputField.text.Trim();
                if (entradaUsuario.Equals("4023", System.StringComparison.OrdinalIgnoreCase))
                {
                    AddCoins(1);

                }
            }

        }
    }
}
