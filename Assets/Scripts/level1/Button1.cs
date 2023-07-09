using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour 
{
    public bool purpleDoor;
    public Animator animator;

    void Update()
    {
        purpleDoor = GetComponent<PurpleDoor>();
    }
    
    
    public void OpenChest()
    {
        if(!purpleDoor)
        {
            purpleDoor = true;
            Debug.Log("Button is pressed");
            animator.SetBool("IsOpen",purpleDoor);
        }
        else
        {
            purpleDoor = false;
            Debug.Log("Button is closed");
            animator.SetBool("IsOpen",purpleDoor);
        }
    }

}
