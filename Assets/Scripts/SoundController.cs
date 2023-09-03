using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource myAudio;
    bool isStart = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStart)
        {
            if (myAudio.isPlaying)
                isStart = true;
        }
        else
        {
            if (!myAudio.isPlaying)
                Destroy(this.gameObject);
        }
    }
}
