using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject bullet;

    void Start()
    {
        
    }

    void Update() 
    {
        transform.Translate(20 * Time.deltaTime * Vector3.right);
    }

    private void OnCollisionEnter(Collision collision) 
    {
        Destroy(bullet);
    }
}
