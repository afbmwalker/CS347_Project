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

public class DeadTurkeyScript : MonoBehaviour
{
    private GameObject parentObject;
    //private GameObject childObject;
    bool inHand = false;
    // Start is called before the first frame update
    void Start()
    {   // establish a parent object to pickup the turkey
        parentObject = GameObject.FindWithTag("TurkeyInHand");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // On Collision, let's pickup turkey
    private void OnCollisionEnter(Collision collision)
    {   // If player walks over the turkey, pick it up
        if(inHand == false && collision.gameObject.tag == "Player")
        {   // Dynamically move dead turkey with player movement
            inHand = true; // you have picked up turkey, prevents weird collider bugs
            this.transform.SetParent(parentObject.transform); // move turkey to player heirarchy
        }
    }

}
