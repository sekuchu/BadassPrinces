using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finnish : MonoBehaviour
{
    public string targetLevel;
    
    // Start is called before the first frame update
    void Start()
    {
        targetLevel = "Level2";
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(targetLevel);
        }
    }
}
