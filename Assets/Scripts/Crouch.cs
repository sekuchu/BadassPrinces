using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{  
    private Vector3 originalScale;
    void Start()
    {   
        originalScale = transform.localScale;
    }
    void Update()
    {
        // Crouch with C key
        if (Input.GetKeyDown(KeyCode.C))
        {
            transform.localScale = new Vector2(originalScale.x, originalScale.y * 0.5f);

        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            transform.localScale = originalScale;
        }
    }
}
