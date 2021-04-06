using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour
{

    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;

    public Rigidbody RB;


    
    // Update is called once per frame
    void Update()
    {

        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        RB.AddForce(transform.forward * translation, ForceMode.VelocityChange);
        RB.AddTorque(0, rotation, 0, ForceMode.Acceleration);
        //transform.Translate(0, 0, translation);
        //transform.Rotate(0, rotation, 0);

    }

}