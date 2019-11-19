using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    Vector3 offset;
    bool zoom = false;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("i") && zoom == true)
        { // Move Camera In or Zoom In
            zoom = false;
            offset.z = offset.z + 5.0f;
        }
        if (Input.GetKey("o") && zoom == false)
        { // Move Camera Out or Zoom Out
            zoom = true;
            offset.z = offset.z - 5.0f;
        }
        transform.position = player.transform.position + offset;
    }
}
