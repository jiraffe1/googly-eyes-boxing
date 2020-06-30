using UnityEngine;

public class lookatme : MonoBehaviour
{
    //another script to help a ragdoll stand up

    public Transform hunt;
    public float huntThreshold;

    // Start is called before the first frame update
    void Start()
    {
      //nothing   
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, hunt.position) < huntThreshold)
        {
            transform.LookAt(hunt);
        }

    }
}
