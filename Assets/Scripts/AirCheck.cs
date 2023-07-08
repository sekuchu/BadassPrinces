using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirCheck : MonoBehaviour
{
    public bool airCheck;
    [SerializeField] private Transform airCheckTransform; // Renamed the variable to avoid naming conflicts
    
    // Start is called before the first frame update
    void Start()
    {
        airCheck = false; // Initializing the airCheck variable to false
    }

    // Update is called once per frame
    void Update()
    {

        if (AirCheckGround())
        {
            airCheck = true;
        }
        else
        {
            airCheck = false;
        }
    }

    private bool AirCheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(airCheckTransform.position, 0.2f);
        
        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("Ground"))
            {
                return true;
            }
        }
        
        return false;
    }
}