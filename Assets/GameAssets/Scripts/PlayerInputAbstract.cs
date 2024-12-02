using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class PlayerInputAbstract : MonoBehaviour
{
    protected PlayerController _controller;
    protected GameInputs _input;

    private void Awake()
    {
        _input = new GameInputs();
        _controller = GetComponent<PlayerController>();
        _input.Player.Enable();
    }
    
    protected abstract void _DoInput();
    private void Update()
    {
        _DoInput();
    }
}
