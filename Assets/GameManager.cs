using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject score;
    public GameObject highestScore;
    private void Start()
    {
        Time.timeScale = 0;
        score.SetActive(true);
        gameOverCanvas.SetActive(false);
        highestScore.SetActive(false);
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        highestScore.SetActive(true);
        score.SetActive(false);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        
        SceneManager.LoadScene(0);
    }
}
