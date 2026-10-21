using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStyle : MonoBehaviour
{
    public GameObject RaxxarBase;
    public GameObject RagnavaldrBase;
    public GameObject KaironBase;
    public GameObject PrometeoBase;
    public GameObject AlmaBase;
    public GameObject BarlemBase;
    public GameObject PepeLouyBase;
    public CaldoDEDragonLogo CDDL;
    public LogIn LI;
    void Start()
    {
        LI = GameObject.Find("Usuary").GetComponent<LogIn>();
        CDDL = GameObject.Find("Usuary").GetComponent<CaldoDEDragonLogo>();

    }
    void Update()
    {
        if (CDDL.ActivateDefault == true)
        {
            if (LI.Anibal)
        {
                RaxxarBase.SetActive(true);
        }
        if (LI.Chispo)
        {       
                RagnavaldrBase.SetActive(true);
        }
        if (LI.Armando)
        {           
                KaironBase.SetActive(true);           
        }
        if (LI.Pablo)
        {   
                PrometeoBase.SetActive(true);           
        }
        if (LI.Samuel)
        {    
                AlmaBase.SetActive(true);    
        }
        if (LI.Ruben)
        {    
                BarlemBase.SetActive(true); 
        }
        if (LI.Jaime)
        {   
                PepeLouyBase.SetActive(true); 
        }
        }
    }
}
