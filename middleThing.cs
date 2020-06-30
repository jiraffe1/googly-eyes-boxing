using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middleThing : MonoBehaviour
{
    //script to help the camera look at the players

    public Transform p1;
    public Transform p2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //go to the average position between player 1 and player 2
        transform.position = Vector3.Lerp(p1.position, p2.position, 0.5f);

        //we have to set a rotation or the c# compiler gets pissed off
        transform.rotation = Quaternion.identity; // set the rotation to itself
    }
}
