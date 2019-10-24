using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Self_distruct : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObjectToDistroy;
    public float waitTime;
    
    public void DestructAfterDelay()
    {
        Destroy(gameObjectToDistroy, waitTime);
    }
}
