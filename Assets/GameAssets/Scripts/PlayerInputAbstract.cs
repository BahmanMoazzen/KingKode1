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
        _input.UI.Enable();
    }
    protected virtual void OnEnable()
    {
        _input.Player.Enable();
        

    }

    protected virtual void OnDisable()
    {
        _input.Player.Disable();
    }
    protected abstract void _DoInput();
    private void Update()
    {
        _DoInput();
    }
}
