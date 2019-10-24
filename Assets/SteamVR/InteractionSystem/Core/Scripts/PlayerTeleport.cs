using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    public Transform teleport1;
    public Transform teleport2;
    public Transform teleport3;
    public Transform teleport4;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Teleport(Transform teleportLocation)
    {
        transform.position = teleportLocation.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
           Teleport(teleport1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Teleport(teleport2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Teleport(teleport3);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Teleport(teleport4);
        }
    }
}
