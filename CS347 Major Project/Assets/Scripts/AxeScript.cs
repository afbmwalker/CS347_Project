using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeScript : MonoBehaviour
{
    public GameObject target;
    public float attackSpeed = 0.1f;
    private bool attackDelay = false;
    private Quaternion idleRotation;

    // Start is called before the first frame update
    void Start()
    {   // initialize the idle rotation value to return to default
        idleRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {   // If attack input given, attack
        if(attackDelay == false && Input.GetKey("space"))
        {
            attackDelay = true; // toggle bool to prevent attack spamming
            Invoke("AttackReset", attackSpeed); // reset bool after attack delay
            transform.rotation = target.transform.rotation; // rotate axe to preset gameobject rotation
        }
    }

    // Creates a delay between attacks
    void AttackReset()
    {   // reset attack delay
        attackDelay = false;
        // reset Axe to default position/rotation
        transform.rotation = idleRotation;
    }
}
