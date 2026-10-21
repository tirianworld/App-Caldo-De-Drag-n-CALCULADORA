using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeUserGM : MonoBehaviour
{
    public LogIn login;

    private void Awake()
    {
        login = GameObject.Find("Usuary").GetComponent<LogIn>();
    }
    public void PepeLouy()
    {
        login.Jaime = true;
        login.Anibal = false;
        login.Pablo = false;
        login.Armando = false;
        login.Ruben = false;
        login.Samuel = false;
        login.Chispo = false;

    }
    public void Raxxar()
    {
        login.Jaime = false;
        login.Anibal = true;
        login.Pablo = false;
        login.Armando = false;
        login.Ruben = false;
        login.Samuel = false;
        login.Chispo = false;


    }
    public void Prometeo()
    {
        login.Jaime = false;
        login.Anibal = false;
        login.Pablo = true;
        login.Armando = false;
        login.Ruben = false;
        login.Samuel = false;
        login.Chispo = false;


    }
    public void Kairon()
    {
        login.Jaime = false;
        login.Anibal = false;
        login.Pablo = false;
        login.Armando = true;
        login.Ruben = false;
        login.Samuel = false;
        login.Chispo = false;


    }
    public void Barlem()
    {
        login.Jaime = false;
        login.Anibal = false;
        login.Pablo = false;
        login.Armando = false;
        login.Ruben = true;
        login.Samuel = false;
        login.Chispo = false;


    }
    public void Cuñao()
    {
        login.Jaime = false;
        login.Anibal = false;
        login.Pablo = false;
        login.Armando = false;
        login.Ruben = false;
        login.Samuel = true;
        login.Chispo = false;


    }
    public void Ragnavaldr()
    {
        login.Jaime = false;
        login.Anibal = false;
        login.Pablo = false;
        login.Armando = false;
        login.Ruben = false;
        login.Samuel = false;
        login.Chispo = true;


    }
}
