using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class Goal : MonoBehaviour
{

    public TextMeshPro scoreText;
    int currentScore ;
    //private void Start()
    //{
    //    scoreText.text = (currentScore.ToString());
    //}
    


    void OnCollisionEnter()
    {
       
    }

    void OnTriggerEnter()
    {
       currentScore  = currentScore +1;
        scoreText.text = (currentScore.ToString());
    }
}