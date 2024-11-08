using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreTxt;
    public GameObject gameOverScreen;

    [Header("---Audio Source---")]
    public AudioSource scoreAudio;
    public AudioSource gameOverAudio;

    public void addScore(int addScore)
    {
        score += addScore;
        scoreTxt.text = score.ToString();
        scoreAudio.Play();
    }

    public void restartGame()
    {
        //Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);

        gameOverAudio.loop = false;
        gameOverAudio.Play();

        //Time.timeScale = 0;
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
