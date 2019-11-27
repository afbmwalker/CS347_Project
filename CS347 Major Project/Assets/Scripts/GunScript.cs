using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletSpawn;
    private float firingSpeed = 0.5f;
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
            Invoke("Attack", firingSpeed);
            Invoke("Shoot", 0.1f);
        }
    }

    // Shoot the gun
    void Shoot()
    {
        GameObject bullets = Instantiate(bullet); // all GUI input for game object and instantiate in game
        bullets.transform.position = bulletSpawn.transform.position; // move object to blimp location
    }

    // Delay the attack
    void Attack()
    {
        attackDelay = false;
    }
}
