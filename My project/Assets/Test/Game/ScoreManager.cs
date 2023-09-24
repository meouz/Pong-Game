using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int rightScore;
    public int leftScore;
    public int maxScore;
    
    public BolaController bola; 
 
    public void AddrightScore(int increment) {
        rightScore += increment;
        bola.ResetBola();

        if (rightScore >= maxScore) {
            GameOver();
        }
    }

    public void AddleftScore(int increment) {
        leftScore += increment;
        bola.ResetBola();

        if (leftScore >= maxScore) {
            GameOver();
        }
    }

    public void GameOver() {
        SceneManager.LoadScene("Main Menu");
    }
   
}