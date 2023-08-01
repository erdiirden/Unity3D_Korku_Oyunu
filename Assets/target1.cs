using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class target1 : MonoBehaviour
{
    public GameObject clock;
    public Light light4;
    public Text text1;
    public Image textbg;
    private float textTime;
    public GameObject openLightSound;
    void Start()
    {
        light4 = GameObject.Find("4").GetComponent<Light>();
        light4.intensity = 0f;
        openLightSound.SetActive(false);
    }
    private void OnMouseDown()
    {
        light4.intensity = 0.4f;
        openLightSound?.SetActive(true);
    }
    void Update()
    {
        textTime += Time.deltaTime;
        if (textTime > 15f)
        {
            text1.gameObject.SetActive(false);
            textbg.gameObject.SetActive(false);
        }
    }
}
