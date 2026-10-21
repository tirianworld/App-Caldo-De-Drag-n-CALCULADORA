using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadjaime : MonoBehaviour
{
    public LogIn LI;

    void Start()
    {
        LI = GameObject.Find("Usuary").GetComponent<LogIn>();
    }
    public void Jaime()
    {
        if (LI.Jaime == true)
        {
            SceneManager.LoadScene(6);
        }

    }
}
