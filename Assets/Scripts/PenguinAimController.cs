using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinAimController : MonoBehaviour
{
    private InputController _controller;
    [SerializeField] private SpriteRenderer _sprite;

    private void Awake()
    {
        _sprite = this.GetComponent<SpriteRenderer>();
        _controller = this.GetComponent<InputController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _controller.OnLookEvent += Look;
    }

    public void Look(Vector2 _direction)
    {
        float degree = Mathf.Atan2(_direction.y, _direction.x) * Mathf.Rad2Deg;
        _sprite.flipX = Mathf.Abs(degree) > 90f;
    }
}
