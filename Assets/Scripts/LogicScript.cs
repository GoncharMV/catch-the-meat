using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score, ultScore;
    public int health, ultHealth;
    public Text scoreText, healthText;
    public GameObject gameOverScreen;

    public void addScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score.ToString();
    }

    public void takeHit(int damage)
    {
        health -= damage;
        healthText.text = health.ToString();
    }

    public void startUlt()
    {
        addScore(ultScore);
        takeHit(-ultHealth);
        
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
