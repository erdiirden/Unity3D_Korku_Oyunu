using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounds : MonoBehaviour
{
    AudioSource textSound;
    public AudioClip text2, text3, text4;
    void Start()
    {
        textSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        textSound.volume = 0.4f;
        if (target2.soundclick==true)
        {
            textSound.clip = text2;
            textSound.Play();
            target2.soundclick = false;
        }
        if (target3.soundclick == true)
        {
            textSound.clip = text3;
            textSound.Play();
            target3.soundclick = false;
        }
        if (target4.soundclick == true)
        {
            textSound.clip = text4;
            textSound.Play();
            target4.soundclick = false;
        }
    }
}
