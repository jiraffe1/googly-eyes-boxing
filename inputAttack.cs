using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputAttack : MonoBehaviour
{
    // rigidbody system allowing for player input.

    public float currentDist;
    public Transform hunt;
    public float multiplier;
    public float attackDur;
    public float attackRange;
    public float attackWait;
    public Rigidbody physicsBody;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentDist = Vector3.Distance(transform.position, hunt.position);
        if (attackWait > 0)
        {
            attackWait -= Time.deltaTime;
        }
        else
        {
            if (Input.GetButton("Fire1")) // if the fire buttin is down
            {
                //attack!
                triggerAttack();
                attackWait = attackDur;
            }
        }
    }

    private void triggerAttack()
    {
        //same range check+rigidbody attack as before, for details see the "attackEnemy" monobehaviour script
        if (Vector3.Distance(transform.position, hunt.position) < attackRange)
        {
            physicsBody.AddForce(new Vector3((transform.position.x - hunt.position.x) * multiplier, (transform.position.y - hunt.position.y) * multiplier, (transform.position.z - hunt.position.z) * multiplier));
        }
    }
}
