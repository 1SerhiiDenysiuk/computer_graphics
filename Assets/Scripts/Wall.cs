using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private GameObject _wall;
    // Start is called before the first frame update
    void Start()
    {
        var rend = GetComponent<Renderer>();
        _wall = gameObject;
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("bullet"))
        {
            Destroy(_wall);
        }
        
    }
}
