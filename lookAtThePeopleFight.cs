using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtThePeopleFight : MonoBehaviour
{
    public Transform p1;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(p1);
    }
}
