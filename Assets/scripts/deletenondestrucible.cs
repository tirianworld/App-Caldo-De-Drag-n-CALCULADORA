using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deletenondestrucible : MonoBehaviour
    
{
    private Logos logos;

    

    void Awake()
    {
        logos = FindObjectOfType<Logos>();
        if (logos == null)
        {
            Debug.LogError("No se encontró ningún componente Logos en la escena.");
            return;
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DestroyLogo()
    {
        Destroy(logos.gameObject);
    }
}
