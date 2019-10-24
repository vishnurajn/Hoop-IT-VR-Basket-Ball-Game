using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel()
    {
       
        SceneManager.LoadScene("week1");
        Debug.Log("Scene Changed");
    }
   public void DoExitGame()
    {
        Application.Quit();
    }
}

