using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounds : MonoBehaviour
{
    AudioSource audiosource;
    public AudioClip text2, text3, text4;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(target2.soundclick==true)
        {
            audiosource.clip = text2;
            audiosource.Play();
            target2.soundclick = false;
        }
        if (target3.soundclick == true)
        {
            audiosource.clip = text3;
            audiosource.Play();
            target3.soundclick = false;
        }
        if (target4.soundclick == true)
        {
            audiosource.clip = text4;
            audiosource.Play();
            target4.soundclick = false;
        }
    }
}
