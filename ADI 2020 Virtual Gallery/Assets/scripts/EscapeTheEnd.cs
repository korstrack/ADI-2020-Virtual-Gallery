using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeTheEnd : MonoBehaviour
{

	public GameObject getOut = null;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
        	if(getOut.activeSelf){
        		getOut.SetActive(false);
        	}
        	else{
	        	getOut.SetActive(true);        	
	        }
        }
    }

    public void EscapeTheFate(){
    	Application.Quit();
    }
}
