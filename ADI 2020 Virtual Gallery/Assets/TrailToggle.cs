using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailToggle : MonoBehaviour
{
	public GameObject Trail = null;
    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z < -100 && this.transform.position.x > -25 && this.transform.position.x < 75){
        	Trail.SetActive(true);
        }
        else{
        	if(Trail.activeSelf){
	        	Trail.SetActive(false);
    		}
        }
    }
}
