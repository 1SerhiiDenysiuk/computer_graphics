using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ShootScript : MonoBehaviour
{
    public GameObject bulletSpawnPoint;
    public GameObject bullet;

    void Update(){
        if (Input.GetButtonDown("Jump"))
            { 
                Transform.Instantiate(bullet, bulletSpawnPoint.transform.position, transform.rotation);
            }
    }
}