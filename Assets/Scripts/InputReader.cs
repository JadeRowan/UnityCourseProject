using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    [SerializeField] private Player.Player _playerEntity;

    private float _horizontalDirection;
    private float _verticalDirection;
    
    void Update()
    {
        _horizontalDirection = Input.GetAxisRaw("Horizontal");
        _verticalDirection = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Jump"))
            _playerEntity.Jump();
    }

    private void FixedUpdate()
    {
        _playerEntity.MoveHorizontally(_horizontalDirection);
        _playerEntity.MoveVertically(_verticalDirection);
    }
}
