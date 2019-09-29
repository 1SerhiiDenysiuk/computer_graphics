﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank_motion : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 800f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(-Vector3.up * turnSpeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime); 
    }
}
