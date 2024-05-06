using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Logic : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;
    private int highscore;
    public Text highscoreText;
    // we can use [ContextMenu("Increase Score")] to test if our functin even works. You then go to the 3 dots dropdown and push the Increase Score button in the dropdown to see if it works
    public void Start()
    {
        updateScore();
    }
    public void addScore(int scoreToAdd)
    {
        score = score + scoreToAdd;
        scoreText.text = score.ToString();
        checkHighScore();
    }
    public void checkHighScore()
    {
        if(score> PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        updateScore();
    }
    public void updateScore()
    {
        highscoreText.text = $"High Score: {PlayerPrefs.GetInt("HighScore", 0)}";
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver ()
    {
        gameOverScreen.SetActive(true);
    }

    public void startGame() {
        SceneManager.LoadScene("Playing Game");
    
    }
    public void home()
    {
        SceneManager.LoadScene("StartGame");
    }
    public void rules()
    {
        SceneManager.LoadScene("Rules");
    }
}
