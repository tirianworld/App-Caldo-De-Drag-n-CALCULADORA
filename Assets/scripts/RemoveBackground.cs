using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBackground : MonoBehaviour
{
    public GameObject Background;
    private void Awake()
    {
        Background = GameObject.Find("Background");
    }
    void Start()
    {
        Background.SetActive(false);
    }

   public void Activate()
    {
        Background.SetActive(true);

    }
}
