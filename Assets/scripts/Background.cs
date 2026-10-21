using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public LogIn LI;
    public GameObject Raxxar;
    public GameObject Ragnavaldr;
    public GameObject Kairon;
    public GameObject Prometeo;
    public GameObject Alma;
    public GameObject Barlem;
    public GameObject PepeLouy;
    public GameObject Invitado;

    public bool KeepDefault;

     void Start()
    {
        LI = GameObject.Find("Usuary").GetComponent<LogIn>();
    }
    void Update()
    {
        if(LI != null)
        {

        if(KeepDefault == false)
        {
            if (LI.Anibal)
            {
                Raxxar.SetActive(true);
                Ragnavaldr.SetActive(false);
                Kairon.SetActive(false);
                Prometeo.SetActive(false);
                Alma.SetActive(false);
                Barlem.SetActive(false);
                PepeLouy.SetActive(false);
                Invitado.SetActive(false);





            }
            if (LI.Chispo)
            {
                Raxxar.SetActive(false);
                Ragnavaldr.SetActive(true);
                Kairon.SetActive(false);
                Prometeo.SetActive(false);
                Alma.SetActive(false);
                Barlem.SetActive(false);
                PepeLouy.SetActive(false);
                Invitado.SetActive(false);





            }
            if (LI.Armando)
            {
                Raxxar.SetActive(false);
                Ragnavaldr.SetActive(false);
                Kairon.SetActive(true);
                Prometeo.SetActive(false);
                Alma.SetActive(false);
                Barlem.SetActive(false);
                PepeLouy.SetActive(false);
                Invitado.SetActive(false);





            }
            if (LI.Pablo)
            {
                Raxxar.SetActive(false);
                Ragnavaldr.SetActive(false);
                Kairon.SetActive(false);
                Prometeo.SetActive(true);
                Alma.SetActive(false);
                Barlem.SetActive(false);
                PepeLouy.SetActive(false);
                Invitado.SetActive(false);





            }
            if (LI.Samuel)
            {
                Raxxar.SetActive(false);
                Ragnavaldr.SetActive(false);
                Kairon.SetActive(false);
                Prometeo.SetActive(false);
                Alma.SetActive(true);
                Barlem.SetActive(false);
                PepeLouy.SetActive(false);
                Invitado.SetActive(false);





            }
            if (LI.Ruben)
            {
                Raxxar.SetActive(false);
                Ragnavaldr.SetActive(false);
                Kairon.SetActive(false);
                Prometeo.SetActive(false);
                Alma.SetActive(false);
                Barlem.SetActive(true);
                PepeLouy.SetActive(false);
                Invitado.SetActive(false);






            }
            if (LI.Jaime)
            {
                Raxxar.SetActive(false);
                Ragnavaldr.SetActive(false);
                Kairon.SetActive(false);
                Prometeo.SetActive(false);
                Alma.SetActive(false);
                Barlem.SetActive(false);
                PepeLouy.SetActive(true);
                Invitado.SetActive(false);





            }
            if (LI.Invitado)
            {
                Raxxar.SetActive(false);
                Ragnavaldr.SetActive(false);
                Kairon.SetActive(false);
                Prometeo.SetActive(false);
                Alma.SetActive(false);
                Barlem.SetActive(false);
                PepeLouy.SetActive(false);
                Invitado.SetActive(true);






            }





        }

            else if(KeepDefault == true)
            {
                Raxxar.SetActive(false);
                Ragnavaldr.SetActive(false);
                Kairon.SetActive(false);
                Prometeo.SetActive(false);
                Alma.SetActive(false);
                Barlem.SetActive(false);
            }
        }
        else 
        {
            KeepDefault = true;
        }

    }

}


