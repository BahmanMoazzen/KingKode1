using UnityEngine;
/// <summary>
/// Abstract class for other inputs
/// </summary>
public abstract class PlayerInputAbstract : MonoBehaviour
{
    /// <summary>
    /// player controller by which player moves
    /// </summary>
    protected PlayerController _controller;
    /// <summary>
    /// Input Actions Class
    /// </summary>
    protected GameInputs _input;

    private void Awake()
    {
        // getting and initializing components
        _input = new GameInputs();
        _controller = GetComponent<PlayerController>();
        _input.Player.Enable();
    }
    /// <summary>
    /// This abstract method must be implemented by every child. It runs every frame
    /// </summary>
    protected abstract void _DoInput();
    private void Update()
    {
        _DoInput();
    }
}
