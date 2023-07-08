using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBetter : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public int jumpPower = 7;
    public bool gc;

    Vector2 originalScale;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
        originalScale = transform.localScale;
    }

    void Update()
    {
        gc = GetComponentInChildren<GroundCheck>().groundCheck;
        
        // A-D movement input for the player
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }

        // Jump with space/w key
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)) && gc == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }

        // Crouch with C key
        if (Input.GetKeyDown(KeyCode.C))
        {
            transform.localScale = new Vector2(originalScale.x, originalScale.y * 0.5f);
            speed = 2f;
            jumpPower = 0;
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            transform.localScale = originalScale;
            speed = 5f;
            jumpPower = 7;
        }

    }
}
