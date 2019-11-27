using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class TankMotion : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float moveSpeed = 10.0f;
    public float rotationSpeed = 800f;
    void Start () {
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Update () {
        Move(KeyCode.UpArrow, 1);
        Move(KeyCode.DownArrow, -1);
        Rotate(KeyCode.RightArrow, -1);
        Rotate(KeyCode.LeftArrow, 1);
    }

    private void Rotate(KeyCode key, int rotateDirection)
    {
        if (Input.GetKey(key))
            transform.Rotate(Time.deltaTime * rotationSpeed * rotateDirection * Vector3.down);
    }

    private void Move(KeyCode key, int direction)
    {    
        if (Input.GetKey(key))
            _rigidbody.velocity = direction * moveSpeed *transform.right;
    }
}
