using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoTransportControl : MonoBehaviour
{
    public GameObject[] videoObjects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        foreach(GameObject video in videoObjects)
        {
            video.GetComponent<UnityEngine.Video.VideoPlayer>().playbackSpeed = 0f;
        }
    }

    void OnTriggerExit(Collider other)
    {
        foreach (GameObject video in videoObjects)
        {
            video.GetComponent<UnityEngine.Video.VideoPlayer>().playbackSpeed = 1f;
        }
    }
}
