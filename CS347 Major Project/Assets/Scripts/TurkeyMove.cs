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

public class TurkeyMove : MonoBehaviour
{
    public uint child1;                         //an unsigned int to specify which child in the turkey hirearchy is the head
    public uint child2;                         //an unsigned int to specify which child in the turkey hirearchy is the tail
    public float speedConstant;                 //a scalar proportional to the turkey's forward velocity
    public float curveConstant;                 //a scalar proportional to the rate at which the turkey turns
    public float changeTimeConstant;            //the time between changes of direction
    private Vector3 rotateVect = Vector3.zero;  //vector3 to hold the turn rotation of the turkey
    public bool moveActive;                     //whether the turkey moves on its own
    public float onCollisionTurn;               //how much the turkey will turn if it collides with an object
    public float minTurnHeight;                 //prevents the turkey from constantly turning on colision with the ground
	
   
    private Vector3 child1Transform;            //transform of the turkey head
    private Vector3 child2Transform;            //transform of the turkey tail
    private Vector3 forwardVect;                //vector of forward velocity
    private Vector3 onCollisionVect = Vector3.zero;     //the turn vector upon colliding with an object
    
    // Start is called before the first frame update
    void Start()
    {

        Invoke("changeCurve", changeTimeConstant);//start a loop to change direction of the turkey randomly at constant time intervals
        onCollisionVect.y = onCollisionTurn;              //initialize collision turn vector
    }

    // Update is called once per frame
    void Update()
    {

        if (moveActive)
        {
            this.transform.Rotate(rotateVect, Space.World);

            child1Transform = this.transform.GetChild((int)child1).position;//get head transform
            child2Transform = this.transform.GetChild((int)child2).position;//get tail transform

            forwardVect = child1Transform - child2Transform; //create a forward vector by taking the difference of the turkey head and tail transforms
            forwardVect.y = 0.0f;                            //lock turkey y
            forwardVect.Normalize();                         
            this.transform.position = this.transform.position + speedConstant * forwardVect; //adds a forward movement vector to the turkey transform
        }

    }
    void changeCurve()//every changeTimeConstant turky changes rate of curve
    {
        rotateVect.y = curveConstant * (Random.value - 0.5f); //change the direction of the turkey
        Invoke("changeCurve", changeTimeConstant); //continue looping
    }
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 toUpright = -1.0f * this.transform.eulerAngles;
        toUpright.y = 0.0f;
        this.transform.Rotate(toUpright);
        if (collision.GetContact(0).point.y > minTurnHeight) //prevents the turkey from turning when it collided with the ground
        {
            this.transform.Rotate(onCollisionVect, Space.World); //turns the turkey
        }
    }
  
}