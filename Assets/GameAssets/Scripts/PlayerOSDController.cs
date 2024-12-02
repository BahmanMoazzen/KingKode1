using UnityEngine;
/// <summary>
/// This class moves the player by OSD joystick
/// </summary>
public class PlayerOSDController : PlayerInputAbstract
{
    protected override void _DoInput()
    {
        // Reading input values
        Vector2 movementFactor = _input.Player.Move.ReadValue<Vector2>() * Time.deltaTime;
        Vector2 lookFactor = _input.Player.Look.ReadValue<Vector2>() * Time.deltaTime;
        // Doing proper movement
        _controller._MoveForward(movementFactor.y);
        _controller._MoveSide(movementFactor.x);
        _controller._Turn(lookFactor.x);
    }


}
