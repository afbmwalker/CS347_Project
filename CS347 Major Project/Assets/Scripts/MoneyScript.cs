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

public class MoneyScript : MonoBehaviour
{
	public Text my_money;
	public string amount;
	public GameObject turkey_prefab;
	public GameObject feather_prefab;
	public bool controller;
	public int count;
	public int feather_x;

    // Start is called before the first frame update
    void Start()
    {   // Initialize a flag and an int for initiating further code.
		controller = false;
        count = 1;

        //Set an initial transform.x for the feather prefabs later.
		feather_x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Check if the flag has been set by OnCollisionEnter.
		if (controller == true)
            //Ensure that this code is only executed once.
			if (count == 1)
			{
				{
                    //Destroys the animated turkey. 
					GameObject turkey_anim;
					turkey_anim = GameObject.Find("Turkey-Animated");
					Destroy(turkey_anim);

                    //Spawns the random-movement turkey.
					Invoke("SpawnTurkey", 1.0f);

                    //Spawns the trail of feathers.
					Invoke("SpawnFeathers", 1.0f);

                    //Displays '$25' to the screen.
					GameObject dollars;
					dollars = GameObject.Find("MyMoney");
					my_money = dollars.GetComponent<Text>();
					my_money.text = "$25";
					amount = my_money.text;

					count--;
				}
			}
    }

    //Handles the player's collisions.
    private void OnCollisionEnter(Collision collision)
	{
		GameObject collidedobject;
		collidedobject = collision.gameObject;

		//When the player enters the shop (touches the floor), sets the flag that allows the code in Update() to run.
		if (collidedobject.gameObject.tag == "Store")
		{
			controller = true;
		}

        //When the player exits the shop (touches the sidewalk), removes the money display from the screen.
        if(collidedobject.gameObject.tag == "Sidewalk")
		{
			GameObject dollars;
			dollars = GameObject.Find("MyMoney");
			my_money = dollars.GetComponent<Text>();
			my_money.text = "";
			amount = my_money.text;
		}
	}

    //Spawns the turkey prefab out in the woods area.
	public void SpawnTurkey()
	{
		GameObject turkey;
		turkey = Instantiate<GameObject>(turkey_prefab);
		turkey.transform.position = this.transform.position + new Vector3(250, 2, 50);
	}

    //Spawns the trail of feathers starting from in front of the house where the player spawns to the woods where the turkey will spawn.
    public void SpawnFeathers()
	{
		GameObject feather;
		
        for(int i = 19; i > 0; i--)
		{
			feather = Instantiate<GameObject>(feather_prefab);
			feather.transform.position = this.transform.position + new Vector3(feather_x, 5, 50);
			feather_x = feather_x + 10;
		}
	}

}
