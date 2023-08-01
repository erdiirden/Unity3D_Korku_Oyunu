using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class target3 : MonoBehaviour
{
    public static bool soundclick = false;
    public GameObject closeDoor, openDoor;
    public GameObject press;
    public Text text3;
    public Image textbg;
    private float textTime;
    private bool textOpen = false;
    public GameObject closeDoorMusic;
    void Start()
    {
        text3.gameObject.SetActive(false);
        textbg.gameObject.SetActive(false);
        closeDoor.SetActive(false);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("character"))
        {
            soundclick = true;
            openDoor.SetActive(false); closeDoor.SetActive(true);
            text3.gameObject .SetActive(true);
            textbg.gameObject .SetActive(true);
            textOpen = true;
            closeDoorMusic.SetActive(true);
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
