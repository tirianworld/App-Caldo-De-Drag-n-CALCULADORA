using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GMSpeccialButtons : MonoBehaviour
{
  public void AníbalButton()
    {
     SceneManager.LoadScene(18);
    }
    public void PabloButton()
    {

    }
    public void ArmandoButton()
    {
        SceneManager.LoadScene(14);
    }
    public void RubenButton()
    {
        SceneManager.LoadScene(16);
    }
    public void ChispoButton()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1zIn1DG-gG1qEZDdmJz5d78wr7b82imoS?usp=sharing");
    }
    public void SamuelButton()
    {

    }
}
