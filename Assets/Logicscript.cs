using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Logicscript : MonoBehaviour
{
    public int Score;
    public Text ScoreText;
    public GameObject GameOverScene;
    public int HighScore;
    public Text HighScoreText;
    public void addscore()
    {
        Score = Score + 1;
        ScoreText.text = Score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    { 
    GameOverScene.SetActive(true);
   
    if (Score > HighScore) 
    {
            HighScore = Score;
            PlayerPrefs.SetInt("HighScore", Score);
            HighScoreText.text = "High Score:"+HighScore.ToString();
        
     }
        
    }
    
    

}

