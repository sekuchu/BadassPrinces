using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField]
    private InputAction action;

    private Animator animator;
    private bool playerCamera = true;

    // Start is called before the first frame update
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }

    void Start()
    {
        action.performed += _ => SwitchState();
    }
    private void SwitchState()
    {
        if(playerCamera)
        {
            animator.Play("PlayerCamera");
        }
        else
        {
            animator.Play("LevelCamera");
        }
        playerCamera = !playerCamera;
    }

}