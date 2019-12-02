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
        bulletPath = bulletDrop.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, bulletPath, bulletSpeed * Time.deltaTime);
    }

}
