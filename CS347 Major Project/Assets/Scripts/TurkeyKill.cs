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

public class TurkeyKill : MonoBehaviour
{
    public GameObject DeadTurkey;
    public uint health;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collidedObj = collision.gameObject;
        // If a weapon hits the Turkey
        if (collidedObj.tag == "Weapon")
        {   // decrement health
            health--;
            if (health==0)
            {   // If health is 0, destroy turkey and spawn a dead turkey object at the location
                Instantiate<GameObject>(DeadTurkey); // spawn dead turkey
                DeadTurkey = GameObject.Find("DeadTurkey(Clone)"); // find location
                DeadTurkey.transform.position = this.transform.position; // move location
                Destroy(this.gameObject); // destroy other turkey
            }
        }
    }
}
