using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {


    public void RestartCurrentLevel()
    {
        //First find out the current active scene
        Scene currentLoadedLevel = SceneManager.GetActiveScene();

        //Second step: Load the scene
        SceneManager.LoadScene(currentLoadedLevel.buildIndex);


    }

}
