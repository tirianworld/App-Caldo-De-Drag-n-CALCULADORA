using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaExtra : MonoBehaviour
{
    public GameObject ExtraLifeButton;
    public GameObject ExtraLifeInputfield;

    // Update is called once per frame
    public void ExtraHealthButton()
    {
        if (!ExtraLifeButton.activeSelf || !ExtraLifeInputfield.activeSelf)
        {
            ExtraLifeButton.SetActive(true);
            ExtraLifeInputfield.SetActive(true);
        }
        else if (ExtraLifeButton.activeSelf || ExtraLifeInputfield.activeSelf)
        {
            ExtraLifeButton.SetActive(false);
            ExtraLifeInputfield.SetActive(false);
        }
    }
}
