using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicSound : MonoBehaviour
{
    private AudioSource musicSounds;
    public AudioClip saw, laugh;
    public static bool sawBool, laughBool;
    void Start()
    {
        musicSounds = GetComponent<AudioSource>();
        sawBool = false;
        laughBool = false;
    }
    void Update()
    {
        if (laughBool)
        {
            musicSounds.volume = 1.0f;
            musicSounds.clip = laugh;
            musicSounds.PlayOneShot(laugh);
            laughBool = false;
            if (sawBool)
            {
                musicSounds.volume = 0.6f;
                musicSounds.clip = saw;
                musicSounds.Play();
            }
        }
    }
}
