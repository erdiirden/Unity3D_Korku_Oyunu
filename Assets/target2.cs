using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class target2 : MonoBehaviour
{
    public static bool soundclick = false;
    public GameObject tv, sawtv;
    public GameObject closeDoor, openDoor;
    public Text text2;
    public Image textbg;
    private float textTime;
    private bool textOpen=false;
    public GameObject requimMusicClose;
    public GameObject openDoorMusic;
    void Start()
    {
        tv.SetActive(false); sawtv.SetActive(false);
        openDoor.SetActive(false); closeDoor.SetActive(true);
        text2.gameObject.SetActive(false);
        textbg.gameObject.SetActive(false);
        openDoorMusic.SetActive(false);
    }
    private void OnMouseDown()
    {
        musicSound.sawBool = true;
        musicSound.laughBool = true;
        requimMusicClose.SetActive(false);
        soundclick = true;
        tv.SetActive(true); sawtv.SetActive(true);
        openDoor.SetActive(true); closeDoor.SetActive(false);
        text2.gameObject.SetActive(true);
        textbg.gameObject.SetActive(true);  
        textOpen = true;
        openDoorMusic.SetActive(true);
    }
    void Update()
    {
        if (textOpen)
        {
            textTime += Time.deltaTime;
            if (textTime > 15f)
            {
                text2.gameObject.SetActive(false);
                textbg.gameObject.SetActive(false);
            }
        } 
    }
}
