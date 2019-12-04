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

public class PlayerMove : MonoBehaviour
{  // Moving Variables
    public float speed;
    // Make house objects transparent for better visual
    public GameObject houseRoof;
    public GameObject wallOne;
    public GameObject wallTwo;
    public GameObject wallThree;
    private Color roofColor, wall1Color, wall2Color, wall3Color;
    private Color transparent;
    // Follow the Mouse, rotate
    public float horizontalSpeed = 2.0f;
    public float verticalSpeed = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        transparent = new Color(0.0f, 0.0f, 0.0f, 0.0f);
        roofColor = houseRoof.GetComponent<Renderer>().material.color;
        wall1Color = wallOne.GetComponent<Renderer>().material.color;
        wall2Color = wallTwo.GetComponent<Renderer>().material.color;
        wall3Color = wallThree.GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {   // Move Forward
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
        }
        // Move Backward
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            transform.position = transform.position + Camera.main.transform.forward * -1 * speed * Time.deltaTime;
        }
        // Move Left
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            transform.position = transform.position + Camera.main.transform.right * -1 * speed * Time.deltaTime;
        }
        // Move Right
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            transform.position = transform.position + Camera.main.transform.right * speed * Time.deltaTime;
        }
        // update camera rotation according to mouse movement
        yaw += horizontalSpeed * Input.GetAxis("Mouse X"); // rotation about x-axis
        pitch -= verticalSpeed * Input.GetAxis("Mouse Y"); // rotation about y-axis
        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f); // fixed z-axis
        camera.transform.eulerAngles = new Vector3(pitch, yaw, 0.0f); // fixed z-axis
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "HouseFloor")
        {
            houseRoof.GetComponent<Renderer>().material.color = transparent;
            wallOne.GetComponent<Renderer>().material.color = transparent;
            wallTwo.GetComponent<Renderer>().material.color = transparent;
            wallThree.GetComponent<Renderer>().material.color = transparent;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.name == "HouseFloor")
        {
            houseRoof.GetComponent<Renderer>().material.color = roofColor;
            wallOne.GetComponent<Renderer>().material.color = wall1Color;
            wallTwo.GetComponent<Renderer>().material.color = wall2Color;
            wallThree.GetComponent<Renderer>().material.color = wall3Color;
        }
    }
}
