/* CS 347 Video Game Design, Fall 2019
 * Dr. Tim Newman
 * Major Project: Slay the Snood
 * Team Members:
 *      Brendan Walker
 *      David Caddell
 *      John Paul Martin
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingScript : MonoBehaviour
{
    public GameObject rock;
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
        if (attackDelay == false && Input.GetKey("space"))
        {
            attackDelay = true; // toggle bool to prevent more than one attack at a time
            Invoke("Attack", firingSpeed); // reset bool after firingSpeed delay, 0.5 seconds seems good
            Invoke("Shoot", 0.1f); // a very quick delay after button press feels pretty good mechanically
        }
    }

    // Shoot the sling
    void Shoot()
    {
        GameObject rocks = Instantiate(rock); // all GUI input for game object and instantiate in game
        rocks.transform.position = bulletSpawn.transform.position; // projectile starting location
        Destroy(rocks, 5);
    }

    // Delay the attack
    void Attack()
    {
        attackDelay = false;
    }
}
