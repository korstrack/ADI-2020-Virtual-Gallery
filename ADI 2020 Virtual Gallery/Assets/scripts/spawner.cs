using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
	#region Variables
	public GameObject spawns;
    public Transform spawnLocation;
    private IEnumerator coroutine;
    public Transform camera;
    public bool isGhosts = false;
    public float minSize = 1;
    public float maxSize = 9;
    public GameObject Exploder = null;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
    	if (spawnLocation == null)
        {
            spawnLocation = transform;
        }
        coroutine = waiter();
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {
        	//Instantiate(spawns);
        	//waiter();
    }

    private IEnumerator waiter(){
    	while(true){
	    	//Debug.Log("ye");
	    	yield return new WaitForSeconds(UnityEngine.Random.Range(1f,12f));
	    	GameObject a = Instantiate(spawns, spawnLocation.position, Quaternion.Euler(new Vector3(0,180,0)));
            if(isGhosts){
    	    	a.GetComponent<LookAtTarget>().target = camera;
	        }
            else{
                a.GetComponent<CoronaCollider>().BadWord = Exploder;
            }
        	//waiter();
            float newScale = UnityEngine.Random.Range(minSize, maxSize);
            a.transform.localScale = new Vector3(newScale, newScale, newScale);
	    }
    }

    
}
