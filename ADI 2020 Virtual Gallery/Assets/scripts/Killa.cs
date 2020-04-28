using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killa : MonoBehaviour
{
    public GameObject playa = null;
    public GameObject target = null;
    public GameObject UICanvas = null;
    public GameObject BADDD = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other){
    	print("wack");
        if(other.gameObject.tag == "Player"){
            print("playa");
            playa.transform.position = target.transform.position;
            //UICanvas.SetActive(true);
            BADDD.SetActive(false);
            BADDD.SetActive(true);
        }
    }
}
