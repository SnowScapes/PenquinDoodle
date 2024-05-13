using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform _transform;

    private void Awake()
    {
        _transform = this.GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        //_transform.position = GameManager.Instance.Player.transform.position;
        //_transform.Translate(new Vector3(0,0,-10));
    }

    private void Update()
    {
        _transform.position = GameManager.Instance.Player.transform.position;
        _transform.Translate(new Vector3(0,0,-10));
    }
}
