using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    private bool weaponSelected = false;
    public GameObject axe;
    public GameObject gun;
    public GameObject sling;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(weaponSelected == false && Input.GetKey("1"))
        {
            axe.SetActive(true);
            weaponSelected = true;
        }
        if (weaponSelected == false && Input.GetKey("2"))
        {
            gun.SetActive(true);
            weaponSelected = true;
        }
        if (weaponSelected == false && Input.GetKey("3"))
        {
            sling.SetActive(true);
            weaponSelected = true;
        }
        if (weaponSelected == true && Input.GetKey("4"))
        {
            gun.SetActive(false);
            sling.SetActive(false);
            axe.SetActive(false);
            weaponSelected = false;
        }
    }
}
