using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTriggerZone : MonoBehaviour
{
    public AudioClip scoreSound;
    private AudioSource scoreAudio;

    bool active = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreAudio = GetComponent<AudioSource>();

        if (active && collision.gameObject.CompareTag("Player"))
        {
            scoreAudio.PlayOneShot(scoreSound, 1.0f);
            active = false;
            ScoreManager.score++;
            Destroy(gameObject);
        }
    }
}

