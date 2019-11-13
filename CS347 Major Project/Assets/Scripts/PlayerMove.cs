using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector3 currPos;
    public float speed;
    public GameObject houseRoof;
    public GameObject wallOne;
    public GameObject wallTwo;
    public GameObject wallThree;
    private Color roofColor, wall1Color, wall2Color, wall3Color;
    private Color transparent;
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
    {
        currPos = transform.position;
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            currPos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            currPos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            currPos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            currPos.x += speed * Time.deltaTime;
        }
        transform.position = currPos;
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
