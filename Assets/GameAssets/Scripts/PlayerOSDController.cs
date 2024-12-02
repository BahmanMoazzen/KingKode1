using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOSDController : PlayerInputAbstract
{


    protected override void _DoInput()
    {
        Vector2 movementFactor = _input.Player.Move.ReadValue<Vector2>() * Time.deltaTime;
        Vector2 lookFactor = _input.Player.Look.ReadValue<Vector2>() * Time.deltaTime;

        _controller._MoveForward(movementFactor.y);
        _controller._MoveSide(movementFactor.x);
        _controller._Turn(lookFactor.x);
    }


}
