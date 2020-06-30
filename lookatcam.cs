using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatcam : MonoBehaviour
{
    /*
     *script for text so it looks at the camera
     *and we can see it better
     */

    //camera to look at
    public Transform toLook;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //look at the camera
        transform.LookAt(toLook);
      
        //make sure the text isnt flipped
        transform.Rotate(Vector3.up - new Vector3(0, 180, 0));
    }
}
