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
public class Help : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            GameObject GlobalPrompt;                                     //This block gets the reference
            Text TextObj;
            GlobalPrompt = GameObject.Find("GlobalPrompt");            //to the text storing the score,
            TextObj = GlobalPrompt.GetComponent<Text>();                //and sets scoreText to this
            TextObj.text = "Goal: Get Revenge On The Turkey\n" +
                "Controls:\n" +
                "Move: Arrow Keys/WASD\n" +
                "Look: Mouse\n" +
                "Buy Weapon: 1, 2, 3\n" +
                "Use Weapon: Space";
        }
        else if (Input.GetKeyUp(KeyCode.H))
        {
            GameObject GlobalPrompt;                                     //This block gets the reference
            Text TextObj;
            GlobalPrompt = GameObject.Find("GlobalPrompt");            //to the text storing the score,
            TextObj = GlobalPrompt.GetComponent<Text>();                //and sets scoreText to this
            TextObj.text = "";
        }
    }
}
