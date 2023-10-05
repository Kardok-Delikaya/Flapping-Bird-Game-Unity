using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("End Game Managment")]
    public GameObject EndGameMenu;
    public void Restart()
    {
        SceneManager.LoadScene("Kardok'sFlappyBird");
        Time.timeScale = 1;
    }

    [Header("Score Managment")]
    public int score;
    public int highScore;
    public Text scoreText;
    public Text highScoreText;

    private void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
            HighScore();
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", 0);
        }
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;

        if (score > highScore)
        {
            highScore = score;
            HighScore();
        }
    }

    void HighScore()
    {
        highScoreText.text = "HighScore: " + highScore;
        PlayerPrefs.SetInt("HighScore", highScore);
    }
}
