using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleDoor : MonoBehaviour
{
    bool key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        key = GetComponent<Button1>().purpleDoor;
        
        if(key == true)
        {
            Destroy(gameObject);
        }
    }
}
