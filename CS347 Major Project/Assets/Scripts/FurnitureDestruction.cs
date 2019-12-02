using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureDestruction : MonoBehaviour
{

    public float xzMagnitude; //modifier for force applied to object in the x and z directions
    public float yMagnitude;    //force applied to an object in the y direction
   

    private void OnCollisionEnter(Collision collision)
	{
    
        GameObject collidedObj;
        Rigidbody collidedRb;
        Vector3 impulseVect;
        
        collidedObj = collision.gameObject;
        collidedRb = collidedObj.GetComponent<Rigidbody>(); //rigid body is what the force will act upon

        if (collidedRb != null) //prevents script from attempting to access a rigidbody that does not exist
        {
            impulseVect = collidedObj.transform.position - this.transform.position; //generate a vector pointing away from

            impulseVect.Normalize();

            impulseVect *= xzMagnitude;
            impulseVect.y = yMagnitude; 

            collidedRb.AddForce(impulseVect, ForceMode.Impulse);
        }
	}
}
