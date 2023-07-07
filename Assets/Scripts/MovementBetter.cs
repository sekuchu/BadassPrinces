using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBetter : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    //public bool gc;

    
    //Pokusavam da napravim da je groundCheck bool iz GroundCheck skripte ovde, nisam uspeo da razumem tutorijal. Nakon sto uspem da napravim ground check referencu u kodu napravicu da igrac skace pomocu toga
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      //  gc = gc.GetComponent<groundCheck>();    
    }

    // Update is called once per frame
    void Update()
    {
        //A-D movement input for the player, will add the jump later 
        if(Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, 0);
        }
        
    }
}
