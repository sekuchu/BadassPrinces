using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDoorButton : MonoBehaviour 
{
    public bool isOpen;
    public Animator animator;
    public GameObject blueDoor;
    public GameObject greenDoor;
    void Start()
    {
        animator.SetBool("IsOpen", isOpen);
    }

    
    public void OpenChest()
    {
        if(!isOpen)
        {
            isOpen = true;
            blueDoor.SetActive(true);
            greenDoor.SetActive(false);
            Debug.Log("Button is pressed");
            animator.SetBool("IsOpen",isOpen);
        }
        else
        {
            isOpen = false;
            blueDoor.SetActive(false);
            greenDoor.SetActive(true);
            Debug.Log("Button is closed");
            animator.SetBool("IsOpen",isOpen);
        }
    }

}
