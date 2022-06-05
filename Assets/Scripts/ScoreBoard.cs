using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    int score;
    TMP_Text scoreText;

     void Start()
     {
         scoreText = GetComponent<TMP_Text>();
         scoreText.text = "Your score: 0";
     }

    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
        scoreText.text = "Your score: " + score;
    }
}
