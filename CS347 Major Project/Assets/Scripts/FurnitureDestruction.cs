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

public class FurnitureDestruction : MonoBehaviour
{

    public float xzMagnitude;   //modifier for force applied to object in the x and z directions
    public float yMagnitude;    //force applied to an object in the y direction
   

    private void OnCollisionEnter(Collision collision)
	{
    
        GameObject collidedObj; //the collided object
        Rigidbody collidedRb; //the rigidbody of the collided object
        Vector3 impulseVect; //the vector designating the impulse to be applied
        
        collidedObj = collision.gameObject; //initialize collided object
        collidedRb = collidedObj.GetComponent<Rigidbody>(); //rigid body is what the force will act upon

        if (collidedRb != null) //prevents script from attempting to access a rigidbody that does not exist
        {
            impulseVect = collidedObj.transform.position - this.transform.position; //generate a vector pointing away from

            impulseVect.Normalize();

            impulseVect *= xzMagnitude; //apply magnitude modifier to the x and z components
            impulseVect.y = yMagnitude; //add new magnitude to y component

            collidedRb.AddForce(impulseVect, ForceMode.Impulse);
        }
	}
}
