using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMotion : MonoBehaviour
{
    Rigidbody _rb;
    public float MoveSpeed = 10.0f;
    public float RotationSpeed = 800f;
    void Start () {
        _rb = GetComponent<Rigidbody>();
    }
    void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rb.velocity = transform.right * MoveSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _rb.velocity = transform.right * -MoveSpeed;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Time.deltaTime * RotationSpeed * Vector3.down);
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Time.deltaTime * RotationSpeed * Vector3.up); 
    }
}
