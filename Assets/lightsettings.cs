using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightsettings : MonoBehaviour
{
    public Light light1, light2;
    bool light1false, light2false = false;
    void Start()
    {
        light1 = GameObject.Find("1").GetComponent<Light>();
        light2 = GameObject.Find("2").GetComponent<Light>();
        light1.intensity = light2.intensity = 0.00001f;
    }

    void Update()
    {
        Invoke("Ligth1OpenChange", 2f);
    }
    void Ligth1OpenChange()
    {
        if(!light1false)
        {
            light1.intensity = 0.4f;
            light1false = true;
        }
        else
        {
            light1.intensity = 0f;
            light1false = false;
        } 
    }
    void Ligth2OpenChange()
    {
        if (!light2false)
        {
            light2.intensity = 0.5f;
            light2false = true;
        }
        else
        {
            light2.intensity = 0f;
            light2false = false;
        }
    }
}
