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
using UnityEngine.UI;

public class WeaponScript : MonoBehaviour
{
	public Text my_money;
	public string amount;
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
    {   // Check to see if in the store, if weapon is equipped, if a weapon is selected
        if(inStore == true && weaponSelected == false && Input.GetKey("1"))
        {   // Equip the Axe by setting it active
            axe.SetActive(true);
            weaponSelected = true;
			GameObject dollars;
			dollars = GameObject.Find("MyMoney");
			my_money = dollars.GetComponent<Text>();
			my_money.text = "$5";
			amount = my_money.text;
		}
        if (inStore == true && weaponSelected == false && Input.GetKey("2"))
        {   // Equip the Gun by setting it active
            gun.SetActive(true);
            weaponSelected = true;
			GameObject dollars;
			dollars = GameObject.Find("MyMoney");
			my_money = dollars.GetComponent<Text>();
			my_money.text = "$5";
			amount = my_money.text;
		}
        if (inStore == true && weaponSelected == false && Input.GetKey("3"))
        {   // Equip the Sling by setting it active
            sling.SetActive(true);
            weaponSelected = true;
			GameObject dollars;
			dollars = GameObject.Find("MyMoney");
			my_money = dollars.GetComponent<Text>();
			my_money.text = "$5";
			amount = my_money.text;
		}
        if (inStore == true && weaponSelected == true && Input.GetKey("4"))
        {
            gun.SetActive(false);
            sling.SetActive(false);
            axe.SetActive(false);
            weaponSelected = false;
			GameObject dollars;
			dollars = GameObject.Find("MyMoney");
			my_money = dollars.GetComponent<Text>();
			my_money.text = "$25";
			amount = my_money.text;
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
