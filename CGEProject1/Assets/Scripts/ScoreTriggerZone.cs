using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTriggerZone : MonoBehaviour
{
    //public AudioClip scoreSound;
    //private AudioSource scoreAudio;

   // private void Start()
    //{
        //scoreAudio = GetComponent<AudioSource>();
    //}

    bool active = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       

        if (active && collision.gameObject.CompareTag("Player"))
        {
           
            active = false;
            ScoreManager.score++;

            collision.gameObject.GetComponent<PlatformerPlayerController>().PlayCoinSound();

            Destroy(gameObject);
        }
    }
}

