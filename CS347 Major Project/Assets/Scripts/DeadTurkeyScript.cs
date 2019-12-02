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
    {
        parentObject = GameObject.FindWithTag("TurkeyInHand");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // On Collision, let's pickup turkey
    private void OnCollisionEnter(Collision collision)
    {
        if(inHand == false && collision.gameObject.tag == "Player")
        {
            print("Dead Turkey!");
            inHand = true;
            //transform.position = deadTurkeyLocation.transform.position;
            this.transform.SetParent(parentObject.transform);
        }
    }

}
