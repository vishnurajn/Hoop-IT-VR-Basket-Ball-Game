using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject gameOverScreen;
	
    //Called when the countdown reaches 0

    public void GameOverLost()
    {
        Debug.Log("Game over. Time-out!!!");
        gameOverScreen.SetActive(true);
    }

  

}
