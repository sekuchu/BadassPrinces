using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonScript : MonoBehaviour 
{
    public bool isOpen;
    public Animator animator;
    public GameObject laser;

    void Start()
    {
        animator.SetBool("IsOpen", isOpen);
    }
    
    public void OpenChest()
    {
        if(!isOpen)
        {
            isOpen = true;
            Debug.Log("Button is pressed");
            laser.SetActive(true);
            animator.SetBool("IsOpen",isOpen);
        }
        else
        {
            isOpen = false;
            Debug.Log("Button is closed");
            laser.SetActive(false);
            animator.SetBool("IsOpen",isOpen);
        }
    }

}
