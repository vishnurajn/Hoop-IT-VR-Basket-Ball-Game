using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class HeightAdjuster : MonoBehaviour
{

    public float adjustmentSpeed=0.01f;
    [SerializeField]
    private float defaultHeight = 1.8f;
    [SerializeField]
    public Camera camera;
    public GameObject HoopRod;
    private float HoopScaleY;



    private void Resize()
    {
        float headHeight = camera.transform.localPosition.y;
        float rodHeight = HoopRod.transform.localPosition.y;
        Debug.Log("Head height is" +headHeight);
        Debug.Log("Rod height is" + rodHeight);
        float scale = headHeight / rodHeight;
         HoopScaleY = HoopRod.transform.localScale.y*scale;

        StartCoroutine(AnimateScaleTo(HoopRod.transform, HoopScaleY,scale));
      //  HoopRod.transform.localScale = new Vector3(HoopRod.transform.localScale.x, HoopScaleY, HoopRod.transform.localScale.z);

        // Vector3 HoopScaleY = HoopRod.transform.localScale.y;


      


    }

    void Start()
    {

        Resize();
       // StartCoroutine(AdjustAfterDelay()) ;
    }


    //IEnumerator AdjustAfterDelay()
    //{
    //    Debug.Log("stand still while dynamically adjust the height");
    //    yield return new WaitForSeconds(3.0f);

    //    Resize();
    
    //}

    IEnumerator AnimateScaleTo(Transform targetTransform, float endValue, float scale)
    {
           Debug.Log("stand still while dynamically adjust the height");
          yield return new WaitForSeconds(3.0f);

        float newValue = targetTransform.localScale.y;

        if (newValue < endValue)
        {
            while (targetTransform.localScale.y < endValue)
            {
                newValue += adjustmentSpeed;
                targetTransform.localScale = new Vector3(targetTransform.localScale.x, newValue, targetTransform.localScale.z);
                yield return new WaitForSeconds(0.011f);
            }
        }
        else
        {
            while (targetTransform.localScale.y > endValue)
            {
                newValue -= adjustmentSpeed;
                targetTransform.localScale = new Vector3(targetTransform.localScale.x, newValue, targetTransform.localScale.z);
                yield return new WaitForSeconds(0.011f);
            }

        }

        Debug.Log("adjusted height to: " + (scale * 100.0f) + "%");

        Debug.Log("scaled rod height" + HoopScaleY);
    }
   
}
