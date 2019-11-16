using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turkeyAutoMove : MonoBehaviour
{
    public uint child1;
    public uint child2;
    public float speedConstant;
    public float curveConstant;
    public float changeTimeConstant;
    private Vector3 rotateVect = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("changeCurve", changeTimeConstant);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 child1Transform;
        Vector3 child2Transform;
        Vector3 forwardVect;

        this.transform.Rotate(rotateVect, Space.World);

        child1Transform = this.transform.GetChild((int)child1).position;
        child2Transform = this.transform.GetChild((int)child2).position;

        forwardVect = child1Transform - child2Transform; //create a vector between 2 points on the turkey
        forwardVect.y = 0.0f;                           //lock turkey y
        forwardVect.Normalize();
        this.transform.position = this.transform.position + speedConstant * forwardVect;//adds a movement vector to the transform


    }
    void changeCurve()//every changeTimeConstant turky changes rate of curve
    {
        rotateVect.y = curveConstant * (Random.value - 0.5f);
        Invoke("changeCurve", changeTimeConstant);
    }
}
