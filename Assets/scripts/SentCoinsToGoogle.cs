using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentCoinsToGoogle : MonoBehaviour
{
    public LogIn LI;
    public string usuario;
    public string coins;
    public CaldoCoins CC;
    void Start()
    {
        LI = GameObject.Find("Usuary").GetComponent<LogIn>();
    }
    [SerializeField]
    
    private string BASE_URL_CALDO_COINS = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSeOx20SQ_hkxuvfk4BDSR09eryBOI4E7HlObG-I837C5NHegg/formResponse";

    
    IEnumerator PostCoins(string coins, string user)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1902026604", coins);
        form.AddField("entry.1461008750", usuario);

        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL_CALDO_COINS, rawData);
        yield return www;

    }

    
    public void sendcoins()
    {
        if (LI.Anibal)
        {
            coins = CC.Caldocoins.ToString();
            usuario = "Raxxar";
        }
        if (LI.Chispo)
        {

            coins = CC.Caldocoins.ToString();
            usuario = "Ragnavaldr";

        }
        if (LI.Armando)
        {

            coins = CC.Caldocoins.ToString();
            usuario = "Kairon";

        }
        if (LI.Pablo)
        {
            coins = CC.Caldocoins.ToString();

            usuario = "Prometeo";

        }
        if (LI.Samuel)
        {
            coins = CC.Caldocoins.ToString();

            usuario = "Alma Fellas";

        }
        if (LI.Ruben)
        {
            coins = CC.Caldocoins.ToString();

            usuario = "Barlem";

        }
        if (LI.Jaime)
        {
            coins = CC.Caldocoins.ToString();

            usuario = "Pepe Louy";
        }
        StartCoroutine(PostCoins(coins, usuario));

    }

}
