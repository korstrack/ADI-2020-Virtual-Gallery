﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoronaCollider : MonoBehaviour
{
	public GameObject BadWord = null;
    private AudioSource audSource;

    void Start()
    {
        audSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other){
    	//print("why th efuck");
    	//print("triggered");
    	if(other.gameObject.tag == "Player"){
            audSource.Play(0);
    		var magnitude = 50;
            // calculate force vector
            var force = other.transform.position - this.gameObject.transform.position;
            // normalize force vector to get direction only and trim magnitude
            force.Normalize();
            this.gameObject.GetComponent<Rigidbody>().AddForce(force * magnitude);
    	}
    	else{
            audSource.Play(0);
    		//print(other.gameObject.tag);
    		Destroy(this.gameObject);
    		BadWord.SetActive(true);
    		//print("swiffered");
    	}
    	
    }
    // 	BadWord.SetActive(true);
    // 	Destroy(this.gameObject);
    // }
}
