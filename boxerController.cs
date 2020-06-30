using UnityEngine;

public class boxerController : MonoBehaviour
{
    // thing which we want to move
    public Rigidbody rb;

    //how hard we want to move the thing
    public float multiplier;

    //how much counter movement to apply
    public float counterMovementTolerance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the x and z axis input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (x == 0 && z == 0) //if no keys are pressed
        {
            //get the velocity
            Vector3 vel = rb.velocity;
            
            //apply counter movement force
            
            rb.AddForce(new Vector3(-vel.x*counterMovementTolerance, -vel.y*counterMovementTolerance, -vel.z*counterMovementTolerance));
        }
        else // if keys are pressed
        {
            //add a force vector with a direction and magnitude equal to the input Vector2
            rb.AddForce(new Vector3(x * multiplier, 0, z * multiplier));
        }
    }
}
