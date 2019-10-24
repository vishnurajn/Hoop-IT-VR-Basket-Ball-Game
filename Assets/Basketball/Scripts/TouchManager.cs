using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour {
    private float InitialTouchTime;
    private float FinalTouchTime;
    private Vector2 InitialTouchPosition;
    private Vector2 FinalTouchPosition;
    private float XaxisForce;
    private float YaxisForce;
    private float ZaxisForce;
    private Vector3 RequiredForce;
    public Rigidbody ball;


	// Use this for initialization
	void Start () {

        ball.useGravity = false;
		
	}
	
    public void OnTouchUp()
    {
        InitialTouchTime = Time.time;
        InitialTouchPosition = Input.mousePosition;
    }

    public void OnTouchDown()
    {
        FinalTouchTime = Time.time;
        FinalTouchPosition = Input.mousePosition;

    }

    public void BallThrow()
    {
        XaxisForce = FinalTouchPosition.x - InitialTouchPosition.x;
        YaxisForce = FinalTouchPosition.y - InitialTouchPosition.y;
        ZaxisForce = FinalTouchTime - InitialTouchTime;
        RequiredForce = new Vector3(-XaxisForce, YaxisForce, -ZaxisForce);
        ball.useGravity = true;
        ball.velocity = RequiredForce;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
