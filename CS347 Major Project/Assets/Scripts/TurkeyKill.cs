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
        if (collidedObj.tag == "Weapon")
        {   // Test
            print("Turkey Hit!");
            health--;
            if (health==0)
            {
                Instantiate<GameObject>(DeadTurkey);
                DeadTurkey.transform.position = this.transform.position;
                print(DeadTurkey.transform.position);
                print(this.transform.position);
                Destroy(this.gameObject);
            }
        }
    }
}
