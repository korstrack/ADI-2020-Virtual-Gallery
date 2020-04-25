using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLegs : MonoBehaviour
{
    public GameObject legs;
    public float moveDistance = 10f;
    public float animationTime = 1f;
    bool legsVisible = true;

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
        if (legsVisible)
        {
            iTween.MoveBy(legs, iTween.Hash("x", -5, "z", moveDistance, "time", animationTime, "easeType", "easeInOutExpo"));
        }
        else
        {
            iTween.MoveBy(legs, iTween.Hash("x", 5, "z", -moveDistance, "time", animationTime, "easeType", "easeInOutExpo"));
        }
        legsVisible = !legsVisible;
    }
}
