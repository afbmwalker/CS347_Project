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

public class RockScript : MonoBehaviour
{
    private float rockSpeed = 10.0f;
    private Vector3 rockPath;
    private GameObject bulletDrop; // projectile destination
    // Start is called before the first frame update
    void Start()
    {
        bulletDrop = GameObject.Find("BulletDrop");
        rockPath = bulletDrop.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, rockPath, rockSpeed * Time.deltaTime);
    }

}
