using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class target5 : MonoBehaviour
{
    public Image end;
    void Start()
    {
        end.gameObject.SetActive(false);
    }
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        end.gameObject.SetActive(true);
    }
}
