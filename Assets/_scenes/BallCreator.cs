using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{


    public GameObject ball;
    public Vector3 ballPos;
    private bool thrown = false;
    private GameObject ballClone;

    private int availableShots = 5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Fire1") && !thrown && availableShots > 0)
        {
            thrown = true;
            availableShots--;
           


            // ballRigidbody.isKinematic = false;
            ballClone = Instantiate(ball, ballPos, transform.rotation) as GameObject;
            

            

        }

        if (ballClone != null && ballClone.transform.position.y < -16)
        {
            Destroy(ballClone);
            thrown = false;
           

            /* Check if out of shots */

            if (availableShots == 0)
            {

            }
        }
    }
}
