using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBetter : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public float speed = 5f;
    public int jumpPower = 10;
    public bool gc;
    public bool ac;
    private int n = 1;
    private bool isCrouching = false; // Flag to track if the player is already crouching

    Vector2 originalScale;
    BoxCollider2D boxCollider;
    Vector2 originalOffset; // Store the original offset value

    public ParticleSystem dust;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        originalScale = transform.localScale;
        boxCollider = GetComponent<BoxCollider2D>();
        originalOffset = boxCollider.offset; // Store the initial offset
    }

    void Update()
    {
        gc = GetComponentInChildren<GroundCheck>().groundCheck;
        ac = GetComponentInChildren<AirCheck>().airCheck;

        // A-D movement input for the player
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            if (n > 0)
            {
                transform.Rotate(0f, 180f, 0f);
                n = -1;
                //This code makes particles every time player changes direction. To prevent spam while in air, I am making sure player is grounded.
                if(gc == true)
                {
                    CreateDust();
                }
            }
            animator.SetFloat("Speed", 1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            if (n < 0)
            {
                transform.Rotate(0f, 180f, 0f);
                n = 1;
                //This code makes particles every time player changes direction. To prevent spam while in air, I am making sure player is grounded.
                if(gc == true)
                {
                    CreateDust();
                }
            }
            animator.SetFloat("Speed", 1);
        }
        else
        {
            animator.SetFloat("Speed", 0);
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }

        // Jump with space/w key
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)) && gc == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            CreateDust();
        }

        // Crouch with C key
        if (Input.GetKeyDown(KeyCode.C) && gc == true && !isCrouching) // Only crouch if not already crouching
        {
            // Shrink the BoxCollider2D when crouching
            boxCollider.size = new Vector2(boxCollider.size.x, boxCollider.size.y * 0.5f);
            boxCollider.offset = new Vector2(boxCollider.offset.x, originalOffset.y - boxCollider.size.y * 0.25f);

            speed = 2f;
            jumpPower = 0;
            animator.SetFloat("Crouch", 1);
            isCrouching = true; // Set the crouching flag to true
        }
        else if (Input.GetKeyUp(KeyCode.C) && ac == false && isCrouching) // Only restore if already crouching
        {
            // Restore the original size and offset of the BoxCollider2D
            boxCollider.size = new Vector2(boxCollider.size.x, boxCollider.size.y * 2f);
            boxCollider.offset = originalOffset;

            speed = 5f;
            jumpPower = 10;
            animator.SetFloat("Crouch", 0);
            isCrouching = false; // Set the crouching flag to false
        }

        // Jump Animation
        if( gc == true)
        {
            animator.SetFloat("Jump", 0);
        }
        else
        {
            animator.SetFloat("Jump", 1);
        }

        //Function that will create dust particles at player feet
        void CreateDust()
        {
            dust.Play();
        }
    }
}