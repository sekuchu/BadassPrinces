using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBetter : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public int jumpPower = 5;
    public bool gc;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        //Making sure that gc is up to date with the groundCheck bool from GroundCheck.cs script
        gc = GetComponentInChildren<GroundCheck>().groundCheck;
        
        //A-D movement input for the player, will add the jump later 
        if(Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }

        //Jump with space/w key

        if((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space)) && gc == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }


        
    }
}
