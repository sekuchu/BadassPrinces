using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateAnimation : MonoBehaviour
{
    public bool po;
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        po = GetComponentInChildren<PresureDection>().pressureOn;

        if(po == true)
        {
            animator.SetFloat("activated", 1);
        }
        else
        {
            animator.SetFloat("activated", 0);
        }
    }
}
