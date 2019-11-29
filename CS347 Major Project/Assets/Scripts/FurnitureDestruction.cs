using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureDestruction : MonoBehaviour
{

    public float forceMagnitude;
    public float upwardMag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
	{
    
        GameObject collidedObj;
        Rigidbody collidedRb;
        Vector3 impulseVect;
        
        collidedObj = collision.gameObject;
        collidedRb = collidedObj.GetComponent<Rigidbody>();
        if (collidedRb != null)
        {
            impulseVect = collidedObj.transform.position - this.transform.position;
            impulseVect.Normalize();
            impulseVect *= forceMagnitude;
            impulseVect.y = upwardMag; 
            collidedRb.AddForce(impulseVect, ForceMode.Impulse);
        }
	}
}
