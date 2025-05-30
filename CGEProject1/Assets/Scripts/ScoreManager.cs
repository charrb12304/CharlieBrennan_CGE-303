using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;

    public TMP_Text textbox;
    public int scoreToWin = 10;
    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    private void Update()
    {
       if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }

       if (score >= scoreToWin)
        {
            won = true;
            gameOver = true;
        }

       if (gameOver)
        {
            if (won)
            {
                textbox.text = "You win!\nPress R to Try Again!";
            }
            else
            {
                textbox.text = "You lose!\nPress R to Try Again!";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
