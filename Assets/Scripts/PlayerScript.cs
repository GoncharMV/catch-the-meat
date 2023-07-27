using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody2D rigidBody;
    public Vector2 move;
    public int health;
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        rigidBody.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        this.health = logic.health;
        if (health > 0)
        {
            move = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rigidBody.velocity.y);
            rigidBody.velocity = move;
        } else
        {
            logic.gameOver();
        }

    } 
}
