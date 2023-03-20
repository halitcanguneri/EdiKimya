using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public Text scoreText;
    public int score;
    public GameObject DeathScreen;
    //public Text highScore;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        //highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }
    public void ScoreArttýr()
    {
        score++;
        scoreText.text = score.ToString();
        //PlayerPrefs.SetInt("HighScore",score);
    }
    public void ScoreAzalt()
    {
        Time.timeScale = 0;
        DeathScreen.SetActive(true);

    }
    
    public void Restartgame()
    {
        SceneManager.LoadScene(1);

    }
    public void menuyegit()
    {
        SceneManager.LoadScene(0);

    }



}
