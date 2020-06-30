using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandUp : MonoBehaviour
{
    // one of the scripts to help a ragdoll stand up

    //whether we want to flop around dead or stand up
    public bool enableThis;

    //default force to add at all times
    public float forceToAdd;

    //force being added at the moment
    public float forceBeingAdded;
    
    //force multiplier
    public float multiplier;

    //target height for the head to be at
    public float targetY;

    //head rigidbody
    public Rigidbody head;

    //acivation boundaries
    public Vector2 min;
    public Vector2 max;

    
    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        //check activation boundaries
        deActivate();

        if (enableThis) // if we arent a ragdoll, 
        { 
            //apply adaptive upward force to the head
            forceBeingAdded = ((targetY - transform.position.y) * multiplier) + forceToAdd;
            //some fancy-looking vector calculations
            head.AddForce(new Vector3(0, ((targetY - transform.position.y) * multiplier) + forceToAdd, 0));
        }
    }

    bool checkIfOffEdge() // check whether it is outside of the activation coordinates
    {
        //format the current position properly
        Vector2 thisPos = new Vector2(transform.position.x, transform.position.z);

        if(thisPos.x > min.x && thisPos.x < max.x && thisPos.y > min.y && thisPos.y < max.y)
        {
            // if the position is within the coordinates, it is not off the edge
            return false;
        }

        //if we arent within the boundaries, we are off the edge. duh
        return true;
    }

    void deActivate()
    {
        //if it is off the edge of the world, 
        if(checkIfOffEdge())
        {
            //turn into a ragdoll
            enableThis = false;
        }
    }
}
