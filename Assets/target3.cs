using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class target3 : MonoBehaviour
{
    public GameObject closeDoor, openDoor;
    public GameObject press;
    public Text text3;
    public Image textbg;
    private float textTime;
    private bool textOpen = false;
    void Start()
    {
        text3.gameObject.SetActive(false);
        textbg.gameObject.SetActive(false);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("character"))
        {
            openDoor.SetActive(false); closeDoor.SetActive(true);
            text3.gameObject .SetActive(true);
            textbg.gameObject .SetActive(true);
            textOpen = true;
        }
    }
    void Update()
    {
        if (textOpen)
        {
            textTime += Time.deltaTime;
            if (textTime > 15f)
            {
                text3.gameObject.SetActive(false);
                textbg.gameObject .SetActive(false);
                press.SetActive(false);
            }
        }
    }
}
