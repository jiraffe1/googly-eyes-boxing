using UnityEngine;

public class dragMe : MonoBehaviour
{
    public Transform hunt;
    public Rigidbody rvb;
    public float multiplier;

    // Start is called before the first frame update
    void Start()
    {
       //wow i just acivated visual studio tools for unity and the difference is huge:
       //noice
    }

    // Update is called once per frame
    void Update()
    {
        rvb.AddForce(new Vector3((transform.position.x - hunt.position.x) * multiplier, (transform.position.y - hunt.position.y) * multiplier, (transform.position.z - hunt.position.z) * multiplier));    
    }
}
