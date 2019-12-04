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

public class BulletScript : MonoBehaviour
{
    private float bulletSpeed = 30.0f;
    private Vector3 bulletPath;
    private GameObject bulletDrop;

    // Start is called before the first frame update
    void Start()
    {   // BulletDrop is an empty GameObject nested under the Gun class.
        bulletDrop = GameObject.Find("BulletDrop");
        // Find the location relative to the player to direct the bullet
        bulletPath = bulletDrop.transform.position;
    }

    // Update is called once per frame
    void Update()
    {   // move bullet in a forward vector
        transform.position = Vector3.MoveTowards(transform.position, bulletPath, bulletSpeed * Time.deltaTime);
    }

}
