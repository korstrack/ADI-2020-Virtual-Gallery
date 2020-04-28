using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepAfterFive : MonoBehaviour
{
    void LateUpdate()
    {
    	StartCoroutine(ExampleCoroutine());
    	
    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        //Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
    	this.gameObject.SetActive(false);
    }
}
