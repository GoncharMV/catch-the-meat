using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public LogicScript logic;
    public int score;
    public int damage; 

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    public void OnTriggerEnter2D(Collider2D fallingObject)
    {
        if (fallingObject.gameObject.tag == "good")
        {
            logic.addScore(score);
            Destroy(fallingObject.gameObject);
        }
        if (fallingObject.gameObject.tag == "bad")
        {
            logic.takeHit(damage);
            Destroy(fallingObject.gameObject);
        }

        if (fallingObject.gameObject.tag == "ult")
        {
            logic.startUlt();
            Destroy(fallingObject.gameObject);
        }
    }
}
