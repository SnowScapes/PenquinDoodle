using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinController : MonoBehaviour
{
    private InputController moveController;
    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private Transform _transform;
    private Transform cam_Transform;

    Vector2 destination = Vector2.zero;

    private void Awake()
    {
        cam_Transform = Camera.main.transform;
        moveController = this.GetComponent<InputController>();
        _transform = this.GetComponent<Transform>();
        rigidBody = this.GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        moveController.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMove(destination);
        //cam_Transform.position = new Vector3(_transform.position.x, _transform.position.y);
        //cam_Transform.Translate(0,0,-10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Move (Vector2 direction)
    {
        destination = direction;
    }

    private void ApplyMove(Vector2 direction)
    {
        direction *= 5;
        rigidBody.velocity = direction;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
    }
}
