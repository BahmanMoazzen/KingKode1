using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    PlayerController _controller;
    [SerializeField] InputActionReference _move;
    
    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
    }
    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {
        
    }
    public void MoveOn(InputAction.CallbackContext iContext)
    {
        if (iContext.started)
        {
            Vector2 moveFactor  = _move.action.ReadValue<Vector2>();
            _controller._MoveForward(moveFactor.x);
            _controller._Turn(moveFactor.y);

        }

    }
}
