using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleDoorScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool key;
    public GameObject purpleDoor;
    [SerializeField] private Button1 buttonRef;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        key = buttonRef.isOpen;
        if(buttonRef.isOpen == false)
        {
            purpleDoor.SetActive(true);
        }
        if(buttonRef.isOpen == true)
        {
            purpleDoor.SetActive(false);
        }
    
    }
}
