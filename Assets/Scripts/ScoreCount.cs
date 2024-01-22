using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    public Text ScoreText, HighScoreText;
    public static float Score, HighScore;

    private void Start()
    {
        Score = 0f;
        if(PlayerPrefs.HasKey("SaveScore"))
        {
            HighScore = PlayerPrefs.GetFloat("SaveScore");
            HighScoreText.text = HighScore.ToString();
        }
    }
    
    public void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "RemoveCars")
        {
            Score = Score + 10f;
            ScoreText.text = Score.ToString();
            Destroy(other.gameObject);
            HighScoreCounter();
        }
    }

    public void HighScoreCounter()
    {
        if(Score > HighScore)
        {
            HighScore = Score;
            PlayerPrefs.SetFloat("SaveScore", HighScore);
        }
    }

    public void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("SaveScore");
        HighScore = 0;
    }
}
