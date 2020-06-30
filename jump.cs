using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float jumpForce;
    public float jumpWait;
    public float jumpDur;
    public Rigidbody jumper;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(jumpWait > 0)
        {
            jumpWait -= Time.deltaTime;
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                activateJump();
                jumpWait = jumpDur;
            }
        }
    }

    void activateJump()
    {
        jumper.AddForce(new Vector3(0,jumpForce,0));
    }
}
