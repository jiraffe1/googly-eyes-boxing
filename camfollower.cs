using UnityEngine;

public class camfollower : MonoBehaviour
{
    public bool active;
    public Transform follow;
    private Vector3 offset = new Vector3(-6,0,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            transform.position = new Vector3(follow.position.x + offset.x, follow.position.y + offset.y, follow.position.z + offset.z);
            transform.rotation = follow.rotation;
        }
    }
}
