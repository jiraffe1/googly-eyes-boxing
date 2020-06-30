using UnityEngine;

public class attackEnemy : MonoBehaviour
{
    public float currentDist;
    //thing to attack
    public Transform hunt;
    public float multiplier;
    //cooldown time
    public float attackDur;
    //attack range
    public float attackRange;
    public float attackWait;
    //p h y s i c s 
    public Rigidbody physicsBody;


    void Start()
    {
        //boxing gloves    
    }

    void Update()
    {
        //get the distance to the enemy for the range check
        currentDist = Vector3.Distance(transform.position, hunt.position);

        if(attackWait > 0)
        {
            //if the timer isnt finished, reduce the wait
            attackWait -= Time.deltaTime;
        }
        else
        {
            //when the wait is 0, trigger the attack...
            triggerAttack();
            //...and reset the timer
            attackWait = attackDur;
        }
    }

    //attack function
    private void triggerAttack()
    {
        if(Vector3.Distance(transform.position, hunt.position) < attackRange) // range check so we dont fly off into space
        {
            physicsBody.AddForce(new Vector3((transform.position.x - hunt.position.x) * multiplier, (transform.position.y - hunt.position.y) * multiplier, (transform.position.z - hunt.position.z) * multiplier)); // apply force to hit the enemy player(s)
            //no animation required, only P H Y S I C S
        }
    }
}
