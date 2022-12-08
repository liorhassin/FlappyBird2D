using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class addScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        Score.score++;
        if (Score.score > HighestScore.highestScore)
        {
            HighestScore.UpdateHighestScore();
        }
    }
}
