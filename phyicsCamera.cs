using UnityEngine;

public class phyicsCamera : MonoBehaviour
{
    public Rigidbody rb;
    public float div;

    void Start()
    {
        
    }


    void Update()
    {
        //get the player's velocity
        Vector3 vel = rb.velocity;
        //adjust position accordingly
        transform.position = new Vector3(transform.position.x + (vel.x/div), transform.position.y + (vel.y/div), transform.position.z + (vel.z/div));
    }
}
