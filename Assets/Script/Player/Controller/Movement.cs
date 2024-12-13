using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharController _controller;
    private CharStatsHandler _stats;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;


    private void Awake()
    {
        _controller = GetComponent<CharController>();
        _stats = GetComponent<CharStatsHandler>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()  //拱府贸府啊 场抄捞饶 贸府 
    {
        ApplyMovment(_movementDirection);

    }


    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }


    private void ApplyMovment(Vector2 direction)
    {
        direction = direction * _stats.CurrentStats.curMoveSpeed;
        _rigidbody.velocity = direction;
    }

}

