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
public class GameEnding : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        GameObject triggeringObj;
        triggeringObj = other.gameObject;
        if (triggeringObj.tag == "DeadTurkey")
        {
            GameObject GlobalPrompt;                    //This block gets the reference
            Text TextObj;
            GlobalPrompt = GameObject.Find("GlobalPrompt");            //to the text storing the score,
            TextObj = GlobalPrompt.GetComponent<Text>();      //and sets scoreText to this
            TextObj.text = "WINNER WINNER TURKEY DINNER!";
            Invoke("QuitApplication", 4.0f);
        }
    }
    private void QuitApplication()
    {
        Application.Quit();
    }
}
