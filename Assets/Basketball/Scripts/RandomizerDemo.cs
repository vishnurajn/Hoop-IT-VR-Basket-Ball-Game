using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizerDemo : MonoBehaviour {
/*
    public int myNum1;
    public int myNum2;
    public int myNum3;
    public int myNum4;
    */

    //Array:
    public int[] myNumArray = new int[4];

    public List<int> myNumList = new List<int>();

    private void Start()
    {
        /*   Debug.Log("myNum1 value is: " + myNum1);
           Debug.Log("myNum2 value is: " + myNum2);
           Debug.Log("myNum3 value is: " + myNum3);
           Debug.Log("myNum4 value is: " + myNum4);
           
              for (int i = 0; i < myNumArray.Length; i++)
            Debug.Log("myNum" + (i + 1) + " value is: " + myNumArray[i]);
         */

        myNumList.Add(15);
        myNumList.Add(25);
        myNumList.Add(55);
        myNumList.Add(85);
        myNumList.Add(185);

        for (int i = 0; i < myNumList.Count; i++)
            Debug.Log("myNum" + (i + 1) + " value is: " + myNumList[i]);

        //"L", "R", "B", "A", "U"

    }


}

