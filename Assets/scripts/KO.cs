using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KO : MonoBehaviour
{
    public GameObject RaxxarKO;
    public GameObject PrometeoKO;
    public GameObject KaironKO;
    public GameObject BarlebKO;
    public GameObject RagnavaldrKO;
    public GameObject AlmaFellasKO;
    public GameObject BossKO;

    public bool Raxxaractive;
    public bool Prometeoactive;
    public bool Kaironactive;
    public bool Barlebactive;
    public bool Ragnavaldractive;
    public bool AlmaFellasactive;
    public bool Bossactive;
    public void ActivateDeactivateKOBoss()
    {
        if (Bossactive == true)
        {
            Bossactive = false;
            BossKO.SetActive(false);
        }
        else if (Bossactive == false)
        {
            Bossactive = true;
            BossKO.SetActive(true);
        }
    }
    public void ActivateDeactivateKORaxxar()
    {
        if (Raxxaractive == true)
        {
            Raxxaractive = false;
            RaxxarKO.SetActive(false);
        }
        else if (Raxxaractive == false)
        {
            Raxxaractive = true;
            RaxxarKO.SetActive(true);
        }
    }
    public void ActivateDeactivateKOPrometeo()
    {
        if (Prometeoactive == true)
        {
            Prometeoactive = false;
            PrometeoKO.SetActive(false);
        }
        else if (Prometeoactive == false)
        {
            Prometeoactive = true;
            PrometeoKO.SetActive(true);
        }
    }
    public void ActivateDeactivateKOKairon()
    {
        if (KaironKO.activeSelf == true)
        {
            KaironKO.SetActive(false);
        }
        else if (KaironKO.activeSelf == false)
        {
            KaironKO.SetActive(true);
        }
    }
    public void ActivateDeactivateKOBarleb()
    {
        if (BarlebKO.activeSelf == true)
        {
            BarlebKO.SetActive(false);
        }
        else if (BarlebKO.activeSelf == false)
        {
            BarlebKO.SetActive(true);
        }
    }
    public void ActivateDeactivateKORagnavaldr()
    {
        if (RagnavaldrKO.activeSelf == true)
        {
            RagnavaldrKO.SetActive(false);
        }
        else if (RagnavaldrKO.activeSelf == false)
        {
            RagnavaldrKO.SetActive(true);
        }
    }

    public void ActivateDeactivateKOAlmaFellas()
    {
        if (AlmaFellasKO.activeSelf == true)
        {
            AlmaFellasKO.SetActive(false);
        }
        else if (AlmaFellasKO.activeSelf == false)
        {
            AlmaFellasKO.SetActive(true);
        }
    }



}
