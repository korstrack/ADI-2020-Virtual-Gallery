// C#
using System;
using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour
{
	//public GameObject g = GameObject.Find("Camera");
     public Transform target;
     Rigidbody asdf;

     void Start(){
     	asdf = GetComponent<Rigidbody>();
     }
      void Update()
      {
           if(target != null)
           {
                transform.LookAt(target);
           }
           if(UnityEngine.Random.Range(0f,100f) > 50){
           	asdf.AddForce(0,Time.deltaTime * 1 * UnityEngine.Random.Range(-20f,20.0f),Time.deltaTime * 1 * UnityEngine.Random.Range(-3f,-5.0f),ForceMode.Impulse);
//           	transform.Translate(Time.deltaTime * -1 * UnityEngine.Random.Range(3f,5.0f),Time.deltaTime * -1, 0);
           }
      //      else{
	     //       asdf.AddForce(Time.deltaTime * -1 * UnityEngine.Random.Range(3f,5.0f),1,0);
    		// }
      }

      void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "KillBox"){
          Destroy(this.gameObject);
        }
    	
    }

}
