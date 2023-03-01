using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Identity_Movement : MonoBehaviour
{
    public CharacterController Controller;

    public float speed = 12f;


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float X_Axis = Input.GetAxis("Horizontal");
        float Z_Axis = Input.GetAxis("Vertical");

        Vector3 Character_Move = transform.right * X_Axis + transform.forward * Z_Axis;
    
        Controller.Move(Character_Move * speed * Time.deltaTime);
    
    }
}
