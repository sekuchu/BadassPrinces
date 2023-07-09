using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteButton : MonoBehaviour 
{
    public bool isOpen;
    public Animator animator;

    public void OpenChest()
    {
        if(!isOpen)
        {
            isOpen = true;
            Debug.Log("Button is pressed");
            animator.SetBool("IsOpen",isOpen);
        }
    }

}
