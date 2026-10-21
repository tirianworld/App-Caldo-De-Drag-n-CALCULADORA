using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesChanger : MonoBehaviour
{
    public int SceneToGo;
   public void ChangeScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }
}
