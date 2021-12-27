using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public static HighScore instance;
    public Text scoreText;
    public Text highScoreText;

    int score = 0 ;
    int highScore = 0;
    private void Awake() {
        instance = this;
    }
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0);
        scoreText.text = "Score : " + score.ToString();
        highScoreText.text = highScore.ToString();
        
    }
    public void AddScore(){
        score +=100;
        scoreText.text = "Score : " + score.ToString();
        if(highScore < score){
            PlayerPrefs.SetInt("highScore", score);
        }
    }
}
