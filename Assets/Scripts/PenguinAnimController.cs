using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PenguinAnimController : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private Rigidbody2D rigidBody;
    private InputController moveController;
    private void Awake()
    {
        moveController = this.GetComponent<InputController>();
        anim = this.GetComponent<Animator>();
        rigidBody = this.GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        moveController.OnMoveEvent += MoveAnimation;
    }

    private void MoveAnimation(Vector2 _velocity)
    {
        if (_velocity == Vector2.zero)
            anim.SetBool("isMoving", false);
        else 
            anim.SetBool("isMoving", true);
    }
}
