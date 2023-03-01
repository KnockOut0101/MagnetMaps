using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MouseLook : MonoBehaviour
{

    public float Mouse_Sensitivity = 250f;

    public Transform playerbody;

    float X_Rotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * Mouse_Sensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * Mouse_Sensitivity * Time.deltaTime;

        X_Rotation -= MouseY;
        X_Rotation = Math.Clamp(X_Rotation, -75f, 75f);

        transform.localRotation = Quaternion.Euler(X_Rotation, 0f, 0f);

        playerbody.Rotate(Vector3.up * MouseX);

    }
}
