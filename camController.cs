using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camController : MonoBehaviour
{
    //simple manual camera movment script to be used in accordance with
    // the "middlething" script with an empty gameobject

    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get input vector
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //apply the movement vector
        transform.position = new Vector3(transform.position.x+(moveSpeed*h), transform.position.y, transform.position.z+(moveSpeed*v));
    }
}
