using System;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public GameManager gameManager;
    public float speed;
    private Rigidbody2D rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // if mouse button left clicked
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * speed;
        }
    }
    
    // If collide with anything, GAME OVER
    private void OnCollisionEnter2D(Collision2D col)
    {
        gameManager.GameOver();
    }
}
