using UnityEngine;
/// <summary>
/// This class implements WASD movement
/// </summary>
public class PlayerInputController : PlayerInputAbstract
{
    protected override void _DoInput()
    {
        // Reading input value
        Vector2 movementFactor = _input.Player.Move.ReadValue<Vector2>() * Time.deltaTime;
        // Using PlayerController to move the player properly
        _controller._MoveForward(movementFactor.y);
        _controller._Turn(movementFactor.x);
    }
}
