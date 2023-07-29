using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isRotating = false;
    private Vector3 mouseStartPos;
    private Vector3 objectStartRotation;
    public float rotationSpeed = 50f; // Örneðin, daha yüksek bir deðer, örneðin 100f.


    public float moveSpeed = 5f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isRotating = true;
            mouseStartPos = Input.mousePosition;
            objectStartRotation = transform.eulerAngles;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isRotating = false;
        }

        if (isRotating)
        {
            Vector3 currentMousePos = Input.mousePosition;
            float deltaX = currentMousePos.x - mouseStartPos.x;

            // Sadece y ekseninde (dikey eksende) dönüþü hesapla ve objenin yeni rotasyonunu ayarla.
            float rotationY = deltaX * rotationSpeed * Time.deltaTime;
            transform.eulerAngles = new Vector3(objectStartRotation.x, objectStartRotation.y + rotationY, objectStartRotation.z);
        }




        float moveHorizontal = 0f;
        float moveVertical = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveHorizontal = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveHorizontal = -1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveVertical = -1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveVertical = 1f;
        }

        Vector3 movement = new Vector3(0f, moveHorizontal, moveVertical) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}

