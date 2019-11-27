using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeScript : MonoBehaviour
{
    public float attackSpeed = 1.0f;
    private bool attackDelay = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(attackDelay == false && Input.GetKey("space"))
        {
            attackDelay = true;
            Invoke("Attack", attackSpeed);

        }
    }

    // Creates a delay between attacks
    void Attack()
    {
        attackDelay = false;
    }
}
