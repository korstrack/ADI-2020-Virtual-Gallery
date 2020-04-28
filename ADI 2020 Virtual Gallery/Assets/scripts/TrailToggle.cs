using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailToggle : MonoBehaviour
{
	public GameObject Trail = null;
	// private Component Footsteps = null;
	// void start()
	// {
	// 	Footsteps = this.GetComponent<AudioSource>();
	// }


  // Update is called once per frame
  void Update()
  {
    //   if(this.transform.position.z < -100f && this.transform.position.x > -25f && this.transform.position.x < 75f){
    //   	Trail.SetActive(true);
    //   }
    //   else{
    //   	if(Trail.activeSelf){
     //    	Trail.SetActive(false);
  		// }
    //   }

      if(this.transform.position.x < -165){
      	//Footsteps.volume = 0.5;
      	this.GetComponent<AudioSource>().volume = 0.25f;
      }
      else{
      	this.GetComponent<AudioSource>().volume = 1f;
      }
  }
  public void OnCollisionEnter(Collision other) {
    print("enterer");
    // how much the character should be knocked back
    var magnitude = 5000;
    // calculate force vector
    var force = transform.position - other.transform.position;
    // normalize force vector to get direction only and trim magnitude
    force.Normalize();
    other.gameObject.GetComponent<Rigidbody>().AddForce(force * magnitude);
  }
}
