using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponScript : MonoBehaviour
{
    private bool weaponSelected = false;
    public GameObject axe;
    public GameObject gun;
    public GameObject sling;
    public GameObject weaponText;
    private bool inStore = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inStore == true && weaponSelected == false && Input.GetKey("1"))
        {
            axe.SetActive(true);
            weaponSelected = true;
        }
        if (inStore == true && weaponSelected == false && Input.GetKey("2"))
        {
            gun.SetActive(true);
            weaponSelected = true;
        }
        if (inStore == true && weaponSelected == false && Input.GetKey("3"))
        {
            sling.SetActive(true);
            weaponSelected = true;
        }
        if (inStore == true && weaponSelected == true && Input.GetKey("4"))
        {
            gun.SetActive(false);
            sling.SetActive(false);
            axe.SetActive(false);
            weaponSelected = false;
        }
    }

    // check to see if in store
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Store")
        {
            weaponText.SetActive(true);
            inStore = true;
        }
        if(other.gameObject.tag == "Sidewalk")
        {
            weaponText.SetActive(false);
            inStore = false;
        }
    }
}
