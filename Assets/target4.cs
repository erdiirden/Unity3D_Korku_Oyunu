using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class target4 : MonoBehaviour
{
    public static bool soundclick = false;
    public GameObject closeDoor, openDoor;
    private string pass = "9:00";
    private float time = 90f;
    public InputField passInput;
    public Button enter;
    public Text counter;
    public Image bgpass;
    private string passUser;
    private bool counterOpen = false;
    public Text text4;
    public Image textbg;
    private float textTime;
    private bool textOpen=false;
    public GameObject openDoorMusic2;
    void Start()
    {
        closeDoor.SetActive(true); openDoor.SetActive(false);
        passInput.gameObject.SetActive(false);
        enter.gameObject.SetActive(false);
        counter.gameObject.SetActive(false);
        text4.gameObject.SetActive(false);
        textbg.gameObject.SetActive(false);
        bgpass.gameObject.SetActive(false);
        openDoorMusic2.SetActive(false);
    }

    private void OnMouseDown()
    {
        soundclick = true;
        passInput.gameObject.SetActive(true);
        enter.gameObject.SetActive(true);
        counter.gameObject.SetActive(true);
        bgpass.gameObject.SetActive(true);
        counterOpen = true;
        text4.gameObject.SetActive(true);
        textbg.gameObject.SetActive(true);
        textOpen = true;
    }
    public void passEnter()
    {
        passUser = passInput.text;
    }
    void Update()
    {
        if(textOpen)
        {
            textTime += Time.deltaTime;
            if (textTime > 15f)
            {
                text4.gameObject.SetActive(false);
                textbg.gameObject.SetActive(false);
            }
        }
        if (counterOpen)
        {
            time -= Time.deltaTime;
        }
        counter.text = time.ToString("F1");
        if (passUser == pass)
        {
            closeDoor.SetActive(false); openDoor.SetActive(true);
            passInput.gameObject.SetActive(false);
            enter.gameObject.SetActive(false);
            bgpass.gameObject.SetActive(false);
            openDoorMusic2.SetActive(true);
        }
    }
}
