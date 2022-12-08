using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighestScore : MonoBehaviour
{
    public static int highestScore;

    private void Start()
    {
        highestScore = PlayerPrefs.GetInt("HighestScore");
    }

    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = highestScore.ToString();
    }

    public static void UpdateHighestScore()
    {
        highestScore = Score.score;
        PlayerPrefs.SetInt("HighestScore", Score.score);
    }
}
