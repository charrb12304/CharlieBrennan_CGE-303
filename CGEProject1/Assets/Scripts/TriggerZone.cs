using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggerZone : MonoBehaviour
{
    //set this reference in the inspector
    public TMP_Text output;

    //enter the text you want to display
    public string textToDisplay;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //set player tag on player in inspector
        if (collision.gameObject.tag == "Player")

        { //display "You Win! on the screen
            output.text = textToDisplay;
        }

    }

}
