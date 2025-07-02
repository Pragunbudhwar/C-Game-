using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicandFunctionality : MonoBehaviour
{
    public int playerScore;
    public int playerLife;
    public Text ScoreText;
    public Text LifeText;

    public int limit = 1;

    public GameObject GameOverScreen;

    [ContextMenu("IncreaseScore")]
    public void addScore(int ScoreToAdd)
    {
        playerScore = playerScore + ScoreToAdd;
        ScoreText.text = playerScore.ToString();
    }

    public void SubtractScore(int ScoreToSubtract)
    {
        playerScore = playerScore - ScoreToSubtract;
        ScoreText.text = playerScore.ToString();
    }

    [ContextMenu("DecreaseLife")]
    public void removeLife()
    {
        if (playerLife > limit)
        {
            playerLife = playerLife - 1;
            LifeText.text = playerLife.ToString();
        }
        else
        {
            GameOverScreen.SetActive(true);
            playerLife = 0;
        }
    
        
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        GameOverScreen.SetActive(true);
    }
    
    
}


