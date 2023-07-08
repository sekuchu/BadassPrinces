using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirCheck : MonoBehaviour
{
    public bool airCheck;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(airCheck);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            airCheck = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            airCheck = false;
        }
    }
}
