using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTrailRenderer : MonoBehaviour
{
    public GameObject trailRenderer;
    public GameObject jetpackTrailL;
    public GameObject jetpackTrailR;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        trailRenderer.SetActive(!trailRenderer.activeSelf);
        jetpackTrailL.SetActive(!jetpackTrailL.activeSelf);
        jetpackTrailR.SetActive(!jetpackTrailR.activeSelf);
    }
}
