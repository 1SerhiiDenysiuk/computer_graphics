using UnityEngine;
using System.Collections;
 
public class shoot : MonoBehaviour {
   
    public GameObject spawnPoint;
    public Rigidbody projectilePrefab;
   
 
    // Use this for initialization
    void Start () {
   
    }
    void OnCollisionEnter(Collision coll){
    Destroy(gameObject);
}
   
    // Update is called once per frame
    void Update () {
       
        if(Input.GetKey(KeyCode.Space))
        {
            Rigidbody hitPlayer;
            hitPlayer = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;
            hitPlayer.velocity = transform.TransformDirection(Vector3.right * 20);
            System.Threading.Thread.Sleep(100);
        }
    }
}