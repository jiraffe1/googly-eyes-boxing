
using UnityEngine;

public class camchicken : MonoBehaviour
{
    public Transform player1;
    public Transform player2;

    void Update()
    {
        transform.LookAt(Vector3.Lerp(player1.position, player2.position, 0.5f));    
    }
}
