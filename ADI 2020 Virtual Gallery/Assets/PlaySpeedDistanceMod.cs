using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PlaySpeedDistanceMod : MonoBehaviour
{

    public float minPlaySpeed = 0.01f;
    public float maxPlaySpeed = 2f;
    public float distanceToMaxSpeed = 5f;
    public float zeroDistanceOffset = 10f;
    public GameObject targetObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float playSpeed = Mathf.Lerp(minPlaySpeed, maxPlaySpeed, mapFloat(Mathf.Clamp(Vector3.Distance(gameObject.transform.position, targetObject.transform.position), 0f, distanceToMaxSpeed) - zeroDistanceOffset, 0f, 0f, distanceToMaxSpeed, 1f));
        GetComponent<UnityEngine.Video.VideoPlayer>().playbackSpeed = playSpeed;
    }

    float mapFloat(float value, float start1, float start2, float end1, float end2)
    {
        return start2 + (end2 - start2) * ((value - start1) / (end1 - start1));
    }
}
