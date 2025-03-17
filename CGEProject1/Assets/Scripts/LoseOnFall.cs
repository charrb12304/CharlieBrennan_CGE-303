using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnFall : MonoBehaviour
{
    public float lowestY;
    void Update()
    {
        if (transform.position.y < lowestY)
        {
            ScoreManager.gameOver = true;
        }
    }
}
