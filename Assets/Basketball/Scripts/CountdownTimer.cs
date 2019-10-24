using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CountdownTimer : MonoBehaviour {

    public GameManager myGameMgr;
    //public Text myTimerText;
    public TextMeshPro m_TextComponent;

    public int timerAtStart=60;  //60, for example
    public int timerCountdownTo=0; //countdown to 0, for example
    public int criticalTimeValue=10;//change color when timer is lower than this value
    public Color criticalTimeColor;

    private float currentTimerVal;

   private bool isCountdownEnded;

	// Use this for initialization
	void Start () {
        
        currentTimerVal = timerAtStart;

        //TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        //m_TextComponent = GetComponent<TextMeshPro>();
        m_TextComponent.text = timerAtStart.ToString();
        //textmeshPro.SetText = timerAtStart.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        if (isCountdownEnded) return;  //so that we prevent the Update function from being executed once we reach the end of timer and once we execute the GameManager.GameOverLost() function call once.

        if (currentTimerVal > timerCountdownTo)
        {
            //currentTimerVal--; //currentTimerVal-=1; or currentTimerVal = currentTimerVal - 1;
            currentTimerVal -= Time.deltaTime;

            m_TextComponent.text = System.Math.Round(currentTimerVal, 0).ToString();

            if (currentTimerVal < criticalTimeValue)
            {
                m_TextComponent.color = criticalTimeColor;
                //Other ways to set a color:
                //myTimerText.color = new Color(0.5f, 0.5f, 0.5f); 
                //myTimerText.color= Color.red;  
            }
        }
        else
        {
            isCountdownEnded = true;
            //Some code to manage game over etc
            myGameMgr.GameOverLost();

        }

    }
}
