using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    PlayerController _controller;
    GameInputs _input;

    private void Awake()
    {
        _input = new GameInputs();
        _controller = GetComponent<PlayerController>();
    }
    private void OnEnable()
    {
        _input.Player.Enable();
        _input.UI.Enable();

    }

    private void OnDisable()
    {
        _input.Player.Disable();
        _input.UI.Disable();
    }
    private void Update()
    {
        Vector2 movementFactor = _input.Player.Move.ReadValue<Vector2>() * Time.deltaTime;
        Debug.Log(movementFactor);
        _controller._MoveForward(movementFactor.y);
        _controller._Turn(movementFactor.x);
    }

}
