using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsView : MonoBehaviour
{
    public Transform playerToFollow;
    public bool toFollow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(toFollow)
        {
            transform.position = playerToFollow.position;
            transform.rotation = playerToFollow.rotation;
        }
    }
}
