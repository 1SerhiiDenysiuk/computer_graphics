using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.Serialization;

public class BulletScript : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float bulletSpeed = 2;
    public GameObject bullet;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _rigidbody.velocity = bulletSpeed * transform.right;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(bullet);
    }
}