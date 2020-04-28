using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoronaCollider : MonoBehaviour
{
	public GameObject BadWord = null;

    void OnTriggerEnter(Collider collision){
    	//print("why th efuck");
    	//print("triggered");
    	if(this.gameObject.tag == "Player"){
    		print(collision.gameObject.tag);
    		print("teleporting");
    		//Vector3 newpos = new Vector3(330, 20, -13);
    		//collision.gameObject.transform.position = new Vector3(330, 20, -13);
    		this.gameObject.transform.position = new Vector3(330, 20, -13);
    		//BadWord.SetActive(true);
    	}
    	else{
    		print(collision.gameObject.tag);
    		Destroy(this.gameObject);
    		//BadWord.SetActive(true);
    		print("swiffered");
    	}
    	
    }
    // 	BadWord.SetActive(true);
    // 	Destroy(this.gameObject);
    // }
}
