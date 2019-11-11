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
    // Start is called before the first frame update
    void Start()
    {
        
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
            houseRoof.SetActive(false);
            wallOne.SetActive(false);
            wallTwo.SetActive(false);
            wallThree.SetActive(false);
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.name == "HouseFloor")
        {
            houseRoof.SetActive(true);
            wallOne.SetActive(true);
            wallTwo.SetActive(true);
            wallThree.SetActive(true);
        }
    }
}
