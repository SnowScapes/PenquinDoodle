using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinAimConroller : MonoBehaviour
{
    private InputController _controller;

    private void Awake()
    {
        _controller = this.GetComponent<InputController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _controller.OnLookEvent += Look;
    }

    public void Look(Vector2 _direction)
    {
        Debug.Log(_direction.magnitude);
    }
}
