using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int playerLives = 3;
    public int playerScore = 0;
    public TextMeshProUGUI playerLivesText;
    public TextMeshProUGUI playerScoreText;
    public GameObject gameOverPanel;
    public bool gameOver = false;

    void Start()
    {
        playerLivesText.text = "LIVES:"+ playerLives;
        playerScoreText.text = "SCORE:" + playerScore;
    }

    void Update()
    {
        if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                gameOver = false;
                playerLives = 3;
                playerScore = 0;
                playerLivesText.text = "LIVES:" + playerLives;
                playerScoreText.text = "SCORE:" + playerScore;
                gameOverPanel.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }

    public void UpdateScore(int amount)
    {
        playerScore += amount;
        if (playerScore <= 0)
        {
            playerScore = 0;
        }
        playerScoreText.text = "SCORE:" + playerScore;
    }

    public void LoseLife()
    {
        playerLives -= 1;
        playerLivesText.text = "LIVES:" + playerLives;

        if (playerLives <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

}
