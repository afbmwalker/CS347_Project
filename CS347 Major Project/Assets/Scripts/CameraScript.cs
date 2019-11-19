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
        if(Input.GetKey("i") && zoom == true)
        {
            zoom = false;
            offset.z = offset.z + 5;
        }
        if (Input.GetKey("o") && zoom == false)
        {
            zoom = true;
            offset.z = offset.z - 5;
        }
        transform.position = player.transform.position + offset;
    }
}
