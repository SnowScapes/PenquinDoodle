using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PenguinAnimController : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private InputController moveController;
    private void Awake()
    {
        moveController = this.GetComponent<InputController>();
        anim = this.GetComponent<Animator>();
    }

    private void Start()
    {
        moveController.OnMoveEvent += MoveAnimation;
    }

    private void MoveAnimation(Vector2 _velocity)
    {
        bool _isMoving = _velocity != Vector2.zero ? true : false;
        anim.SetBool("isMoving", _isMoving);
    }
}
