using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
	public Text my_money;
	public string amount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
	{
		GameObject collidedobject;
		collidedobject = collision.gameObject;

        if(collidedobject.gameObject.tag == "Store")
		{
			GameObject dollars;
			dollars = GameObject.Find("MyMoney");
			my_money = dollars.GetComponent<Text>();
			my_money.text = "$25";
			amount = my_money.text;
		}

        if(collidedobject.gameObject.tag == "Sidewalk")
		{
			GameObject dollars;
			dollars = GameObject.Find("MyMoney");
			my_money = dollars.GetComponent<Text>();
			my_money.text = "";
			amount = my_money.text;
		}

        //Replace this code after picking up weapons has been finalized.
		if (collidedobject.gameObject.tag == "Weapon")
		{
			GameObject dollars;
			dollars = GameObject.Find("MyMoney");
			my_money = dollars.GetComponent<Text>();
			my_money.text = "$5";
			amount = my_money.text;
		}
	}
}
