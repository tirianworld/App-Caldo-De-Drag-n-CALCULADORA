using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultLogo : MonoBehaviour
{
    public CaldoDEDragonLogo CDDL;
    public bool defaultlogo;
     void Awake()
    {
        CDDL = GameObject.Find("Usuary").GetComponent<CaldoDEDragonLogo>();
    }
    void Start()
    {
        if(defaultlogo == true)
        {
            CDDL.Default = true;
        }
    }
}
