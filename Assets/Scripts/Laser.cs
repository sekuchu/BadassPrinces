using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    // Use this for initialization
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
{
    _lineRenderer.SetPosition(0, transform.position);
    RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
    if (hit.collider)
    {
        _lineRenderer.SetPosition(1, new Vector3(hit.point.x, hit.point.y, transform.position.z));
        
        if (hit.collider.CompareTag("Player"))
        {
            Debug.Log("Player Died");
            // ovde moramo skriptu za smrt stavit
        }
    }
    else
    {
        _lineRenderer.SetPosition(1, transform.up * 2000);
    }
}
}