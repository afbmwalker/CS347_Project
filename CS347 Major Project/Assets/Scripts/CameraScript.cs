using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Follow the Player, position
    public GameObject player;
    // Follow the Mouse, rotate
    public float horizontalSpeed = 2.0f;
    public float verticalSpeed = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    // Zoom in and out
    Vector3 offset;
    bool zoom = false;

    // Start is called before the first frame update
    void Start()
    {   // establish initial offset between camera and player and maintain integrity
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {   // Zoom In using 'i'
        if(Input.GetKey("i") && zoom == true)
        {
            zoom = false; // toggle bool to allow fixed zoom
            offset.z = offset.z + 5; // zoom distance
        }
        // Zoom Out using 'o'
        if (Input.GetKey("o") && zoom == false)
        {
            zoom = true;
            offset.z = offset.z - 5; // zoom distance
        }
        // update camera position
        transform.position = player.transform.position + offset;
        // update camera rotation according to mouse movement
        yaw += horizontalSpeed * Input.GetAxis("Mouse X"); // rotation about x-axis
        pitch -= verticalSpeed * Input.GetAxis("Mouse Y"); // rotation about y-axis
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f); // fixed z-axis
    }
}
