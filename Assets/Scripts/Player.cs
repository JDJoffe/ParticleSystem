﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class Player : MonoBehaviour
{

    public GameObject arrow;
    CharacterController character;
    public Camera headCam;
    public float speed = 6;
    public float gravity = 9.8f;
    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;
    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;
    private float rotationVert = 0;
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        movement();
        rotation();
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }
    public void movement()
    {
        if (Input.GetKey(KeyCode.LeftShift)) { speed = 9f; }
        else { speed = 6; }
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = -gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        character.Move(movement);
    }
    public void rotation()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        rotationVert -= Input.GetAxis("Mouse Y") * sensitivityVert;
        rotationVert = Mathf.Clamp(rotationVert, minimumVert, maximumVert);
        headCam.transform.localEulerAngles = new Vector3(rotationVert, headCam.transform.localEulerAngles.y, 0);
    }
    public void shoot()
    {
        Rigidbody rb;
        GameObject clone = Instantiate(arrow, transform.position + Vector3.forward, transform.rotation);
        rb = clone.GetComponent<Rigidbody>();
        rb.AddForce(clone.transform.forward * 1000f);
        clone.transform.LookAt(transform.position);
    }
}
