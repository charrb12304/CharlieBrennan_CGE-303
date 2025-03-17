using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class TriggerZone : MonoBehaviour
{
    public TMP_Text output;

    public string textToDisplay;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            output.text = textToDisplay;
        }
    }
}
