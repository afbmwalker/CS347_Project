using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
	public Text my_money;
	public string amount;
	public GameObject turkey_prefab;
	public bool controller;
	public int count;

    // Start is called before the first frame update
    void Start()
    {   
		controller = false;
        count = 1;
    }

    // Update is called once per frame
    void Update()
    {
		if (controller == true)
			if (count == 1)
			{
				{
					GameObject turkey_anim;
					turkey_anim = GameObject.Find("Turkey-Animated");
					Destroy(turkey_anim);

					Invoke("SpawnTurkey", 1.0f);

					GameObject dollars;
					dollars = GameObject.Find("MyMoney");
					my_money = dollars.GetComponent<Text>();
					my_money.text = "$25";
					amount = my_money.text;

					count--;
				}
			}
    }

    private void OnCollisionEnter(Collision collision)
	{
		GameObject collidedobject;
		collidedobject = collision.gameObject;

        if(collidedobject.gameObject.tag == "Store")
		{
			controller = true;
		}

        if(collidedobject.gameObject.tag == "Sidewalk")
		{
			GameObject dollars;
			dollars = GameObject.Find("MyMoney");
			my_money = dollars.GetComponent<Text>();
			my_money.text = "";
			amount = my_money.text;
		}
	}

	public void SpawnTurkey()
	{
		GameObject turkey;
		turkey = Instantiate<GameObject>(turkey_prefab);
		turkey.transform.position = this.transform.position + new Vector3(250, 2, 50);
	}

}
