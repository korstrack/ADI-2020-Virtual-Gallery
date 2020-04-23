using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinSpawner : MonoBehaviour
{
	#region Variables
	public GameObject spawns;
    public Transform spawnLocation;
    private IEnumerator coroutine;
    public Transform camera;
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
	    	Debug.Log("ye");
	    	yield return new WaitForSeconds(UnityEngine.Random.Range(1f,12f));
	    	GameObject a = Instantiate(spawns, spawnLocation.position, Quaternion.Euler(new Vector3(0,180,0)));
	    	//waiter();
	    }
    }

    
}
