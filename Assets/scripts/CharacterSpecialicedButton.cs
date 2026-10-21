using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSpecialicedButton : MonoBehaviour
{
    public Button CharSpButton;
    public LogIn login;
    public Button RaxxarButton;
    public Button RagnavaldrButton;
    public Button KaironButton;
    public Button PrometeoButton;
    public Button AlmaButton;
    public Button BarlemButton;









    // Start is called before the first frame update
    private void Awake()
    {
        login = GameObject.Find("Usuary").GetComponent<LogIn>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (login.Anibal == true)
        {
            CharSpButton = RaxxarButton;
        }
        if (login.Pablo == true)
        {
            CharSpButton = PrometeoButton;
        }
        if (login.Armando == true)
        {
            CharSpButton = KaironButton;
        }
        if (login.Ruben == true)
        {
            CharSpButton = BarlemButton;
        }
        if (login.Samuel == true)
        {
            CharSpButton = AlmaButton;

        }
        if (login.Chispo == true)
        {
            CharSpButton = RagnavaldrButton;
        }
    }
    public void CharacterspButton()
    {
        if (login.Anibal == true)
        {

        }
        if (login.Pablo == true)
        {

        }
        if (login.Armando == true)
        {
         SceneManager.LoadScene(13);
        }
        if (login.Ruben == true)
        {
            SceneManager.LoadScene(15);
        }
        if (login.Samuel == true)
        {

        }
        if (login.Chispo == true)
        {
         Application.OpenURL("https://drive.google.com/drive/folders/1zIn1DG-gG1qEZDdmJz5d78wr7b82imoS?usp=sharing");
        }
    }
}
