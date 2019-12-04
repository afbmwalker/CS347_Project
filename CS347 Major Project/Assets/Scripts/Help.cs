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
        if (Input.GetKeyDown(KeyCode.H))//if the h key is pressed
        {
            GameObject GlobalPrompt;                                     //This block gets the reference
            Text TextObj;                                                //to the text object to hold
            GlobalPrompt = GameObject.Find("GlobalPrompt");              //the help text and inserts
            TextObj = GlobalPrompt.GetComponent<Text>();                 //the text for display
            TextObj.text = "Goal: Get Revenge On The Turkey\n" +         //
                "Controls:\n" +                                          //
                "Move: Arrow Keys/WASD\n" +                              //
                "Look: Mouse\n" +                                        //
                "Buy Weapon: 1, 2, 3\n" +                                //
                "Use Weapon: Space";                                     //
        }
        else if(Input.GetKeyUp(KeyCode.H))//if the h key is released
        {
            GameObject GlobalPrompt;                                     //This block gets the reference
            Text TextObj;                                                //to the text object holding 
            GlobalPrompt = GameObject.Find("GlobalPrompt");              //the help text and removes
            TextObj = GlobalPrompt.GetComponent<Text>();                 //the text from the screen
            TextObj.text = "";                                           //
        }
    }
}
