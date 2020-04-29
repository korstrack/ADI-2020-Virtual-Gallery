﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeTheEnd : MonoBehaviour
{

	public GameObject getOut = null;
	public GameObject Controls = null;
	public GameObject EscHowto = null;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
        	if(getOut.activeSelf){
        		getOut.SetActive(false);
        		Controls.SetActive(false);
        		EscHowto.SetActive(false);
        		Cursor.lockState = CursorLockMode.Locked;
        		Cursor.visible = false;
        	}
        	else{
	        	getOut.SetActive(true);
	        	Controls.SetActive(true);
	        	EscHowto.SetActive(true);
	        	Cursor.lockState = CursorLockMode.None;
	        	Cursor.visible = true;  	
	        }
        }
    }

    public void EscapeTheFate(){
    	Application.Quit();
    }
}
