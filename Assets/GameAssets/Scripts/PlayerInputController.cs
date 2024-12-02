using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : PlayerInputAbstract
{
    protected override void _DoInput()
    {
        Vector2 movementFactor = _input.Player.Move.ReadValue<Vector2>() * Time.deltaTime;
        _controller._MoveForward(movementFactor.y);
        _controller._Turn(movementFactor.x);
    }
}
