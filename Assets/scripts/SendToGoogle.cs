using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendToGoogle : MonoBehaviour
{
    public LogIn LI;
    public GameObject oro;
    public string golds;
    public string usuario;
    public string coins;
    public CaldoCoins CC;

    public gold gold;
    void Start()
    {
        LI = GameObject.Find("Usuary").GetComponent<LogIn>();
        
    }
    [SerializeField]
    private string BASE_URL_GOLD = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSfojFKLTUASn334v_WuX2jJ9D7g1-dsq7zWUYUVI-QspWcEvQ/formResponse";
   

    IEnumerator PostGold(string golds, string user)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1252705956", golds);
        form.AddField("entry.101386011", usuario);

        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL_GOLD, rawData);
        yield return www;
            
    }
    

    public void send()
    {
        if (LI.Anibal)
        {
            golds = gold.RaxxarsavedNumber.ToString();
            usuario = "Raxxar";
        }
        if (LI.Chispo)
        {

            golds = gold.RagnavaldrsavedNumber.ToString();
            usuario = "Ragnavaldr";

        }
        if (LI.Armando)
        {

            golds = gold.KaironsavedNumber.ToString();
            usuario = "Kairon";

        }
        if (LI.Pablo)
        {
            golds = gold.PrometeosavedNumber.ToString();
            usuario = "Prometeo";

        }
        if (LI.Samuel)
        {
            golds = gold.AlmaFellassavedNumber.ToString();
            usuario = "Alma Fellas";

        }
        if (LI.Ruben)
        {
            golds = gold.BarlemsavedNumber.ToString();
            usuario = "Barled";

        }
        if (LI.Jaime)
        {
            golds = gold.PepeLouysavedNumber.ToString();
            usuario = "Pepe Loux";
        }
        StartCoroutine(PostGold(golds, usuario));
        
    }
    

}
