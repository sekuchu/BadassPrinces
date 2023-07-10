using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour 
{
    public bool isOpen;
    public Animator animator;
    public GameObject purpleDoor;
    public void Start()
    {
        isOpen = true;
        animator.SetBool("IsOpen", isOpen);
    }
    
    public void OpenButton()
    {
        if(!isOpen)
        {
            isOpen = true;
            purpleDoor.SetActive(true);
            Debug.Log("Button is pressed");
            animator.SetBool("IsOpen",isOpen);
        }
        else
        {
            isOpen = false;
            purpleDoor.SetActive(false);
            Debug.Log("Button is closed");
            animator.SetBool("IsOpen",isOpen);
        }
    }

}

