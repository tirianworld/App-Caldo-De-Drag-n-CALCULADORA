using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellsList : MonoBehaviour
{
    public GameObject[] RaxxarSpells;
    public GameObject[] PrometeoSpells;
    public GameObject[] KaironSpells;
    public GameObject[] BarledSpells;
    public GameObject[] RagnavaldrSpells;
    public GameObject[] AlmaFellasSpells;
    bool RaxxarActive     = false;
    bool PrometeoActive   = false;
    bool KaironActive     = false;
    bool BarledActive     = false;
    bool RagnavaldrActive = false;
    bool AlmaFellasActive = false;


    private void Update()
    {

        foreach (GameObject spell in RaxxarSpells)
        {
            if (spell.activeSelf)
            {
                RaxxarActive = true;
            }
        }
        foreach (GameObject spell in PrometeoSpells)
        {
            if (spell.activeSelf)
            {
                PrometeoActive = true;
            }
        }
        foreach (GameObject spell in KaironSpells)
        {
            if (spell.activeSelf)
            {
                KaironActive = true;
            }
        }
        foreach (GameObject spell in RagnavaldrSpells)
        {
            if (spell.activeSelf)
            {
                RagnavaldrActive  = true;
            }
        }
        foreach (GameObject spell in BarledSpells)
        {
            if (spell.activeSelf)
            {
                BarledActive = true;
            }
        }
        foreach (GameObject spell in AlmaFellasSpells)
        {
            if (spell.activeSelf)
            {
                AlmaFellasActive = true;
            }
        }
    }
    public void ChangeFront()
    {
     if(RaxxarActive == true)
        {
            foreach (GameObject spell in RaxxarSpells)
            {
                gameObject.SetActive(false);
            }
            foreach (GameObject spell in PrometeoSpells)
            {
                gameObject.SetActive(true);
            }
        }
        else if(PrometeoActive == true)
        {
            foreach (GameObject spell in PrometeoSpells)
            {
                gameObject.SetActive(false);
            }
            foreach (GameObject spell in KaironSpells)
            {
                gameObject.SetActive(true);
            }
        }
        else if (KaironActive == true)
        {
            foreach (GameObject spell in KaironSpells)
            {
                gameObject.SetActive(false);
            }
            foreach (GameObject spell in BarledSpells)
            {
                gameObject.SetActive(true);
            }
        }
        else if (BarledActive == true)
        {
            foreach (GameObject spell in BarledSpells)
            {
                gameObject.SetActive(false);
            }
            foreach (GameObject spell in RagnavaldrSpells)
            {
                gameObject.SetActive(true);
            }
        }
        else if (RagnavaldrActive == true)
        {
            foreach (GameObject spell in RagnavaldrSpells)
            {
                gameObject.SetActive(false);
            }
            foreach (GameObject spell in AlmaFellasSpells)
            {
                gameObject.SetActive(true);
            }
        }
        else if (AlmaFellasActive == true)
        {
            foreach (GameObject spell in AlmaFellasSpells)
            {
                gameObject.SetActive(false);
            }
            foreach (GameObject spell in RaxxarSpells)
            {
                gameObject.SetActive(true);
            }
        }
    }
    public void ChangeBack()
    {
        if (RaxxarActive == true)
        {
            foreach (GameObject spell in RaxxarSpells)
            {
                gameObject.SetActive(false);
            }
            foreach (GameObject spell in AlmaFellasSpells)
            {
                gameObject.SetActive(true);
            }
        }
        else if (PrometeoActive == true)
        {
            foreach (GameObject spell in PrometeoSpells)
            {
                gameObject.SetActive(false);
            }
            foreach (GameObject spell in RaxxarSpells)
            {
                gameObject.SetActive(true);
            }
        }
        else if (KaironActive == true)
        {
            foreach (GameObject spell in KaironSpells)
            {
                gameObject.SetActive(false);
            }
            foreach (GameObject spell in PrometeoSpells)
            {
                gameObject.SetActive(true);
            }
        }
        else if (BarledActive == true)
        {
            foreach (GameObject spell in BarledSpells)
            {
                gameObject.SetActive(false);
            }
            foreach (GameObject spell in KaironSpells)
            {
                gameObject.SetActive(true);
            }
        }
        else if (RagnavaldrActive == true)
        {
            foreach (GameObject spell in RagnavaldrSpells)
            {
                gameObject.SetActive(false);
            }
            foreach (GameObject spell in BarledSpells)
            {
                gameObject.SetActive(true);
            }
        }
        else if (AlmaFellasActive == true)
        {
            foreach (GameObject spell in AlmaFellasSpells)
            {
                gameObject.SetActive(false);
            }
            foreach (GameObject spell in RagnavaldrSpells)
            {
                gameObject.SetActive(true);
            }
        }
    }


}
