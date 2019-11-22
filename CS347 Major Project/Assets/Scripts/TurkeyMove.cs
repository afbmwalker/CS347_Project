using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurkeyMove : MonoBehaviour
{
    public uint child1;
    public uint child2;
    public float speedConstant;
    public float curveConstant;
    public float changeTimeConstant;
    private Vector3 rotateVect = Vector3.zero;
    public bool moveActive;
    public float onCollisionTurn;
    public float minTurnHeight;
   
    private Vector3 child1Transform;
    private Vector3 child2Transform;
    private Vector3 forwardVect;
    private Vector3 reverse = Vector3.zero;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("changeCurve", changeTimeConstant);
        reverse.y = onCollisionTurn;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveActive)
        {

            this.transform.Rotate(rotateVect, Space.World);

            child1Transform = this.transform.GetChild((int)child1).position;
            child2Transform = this.transform.GetChild((int)child2).position;

            forwardVect = child1Transform - child2Transform; //create a vector between 2 points on the turkey
            forwardVect.y = 0.0f;                           //lock turkey y
            forwardVect.Normalize();
            this.transform.position = this.transform.position + speedConstant * forwardVect; //adds a movement vector to the transform
        }

    }
    void changeCurve()//every changeTimeConstant turky changes rate of curve
    {
        rotateVect.y = curveConstant * (Random.value - 0.5f);
        Invoke("changeCurve", changeTimeConstant);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 toUpright = -1.0f * this.transform.eulerAngles;
        toUpright.y = 0.0f;
        this.transform.Rotate(toUpright);
        if (collision.GetContact(0).point.y > minTurnHeight) //prevents the turkey from turning when it collided with the ground
        {
            //this.transform.eulerAngles
            //this.transform.Rotate(-1.0f * this.transform.eulerAngles);
            this.transform.Rotate(reverse, Space.World);
            // forwardVect = -1.0f * forwardVect;
            //rotateVect.y = 1.0f+rotateVect.y;
        }
    }
  
}