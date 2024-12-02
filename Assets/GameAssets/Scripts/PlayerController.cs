using UnityEngine;
/// <summary>
/// This class controles the movement and turn of the player
/// </summary>
public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// The character controller that handles movement
    /// </summary>
    CharacterController _controller;
    /// <summary>
    /// Move forward speed
    /// </summary>
    [SerializeField] float _moveSpeed;
    /// <summary>
    /// Move side speed
    /// </summary>
    [SerializeField] float _sideSpeed;
    /// <summary>
    /// Turn speed
    /// </summary>
    [SerializeField] float _turnSpeed;
    /// <summary>
    /// The axis upone which the player rotates.
    /// </summary>
    [SerializeField] Vector3 _turnAxis = new Vector3(0, 1, 0);
    private void Awake()
    {
        // Getting components
        _controller = GetComponent<CharacterController>();
    }
    /// <summary>
    /// Force player move forwards and bachwards base on iForwardFactor
    /// </summary>
    /// <param name="iForwardFactor">Defines whether player goes forward and backward and in which strength between -1 and 1</param>
    public void _MoveForward(float iForwardFactor)
    {
        _controller.Move(transform.forward * _moveSpeed * iForwardFactor);
    }
    /// <summary>
    /// Force player move sideways base on iSideFactor
    /// </summary>
    /// <param name="iSideFactor">Defines in which direction player goes and with which magnetitude</param>
    public void _MoveSide(float iSideFactor)
    {
        _controller.Move(transform.right * _sideSpeed * iSideFactor);
    }
    /// <summary>
    /// Turns the player
    /// </summary>
    /// <param name="iTurnFactor">With wich magnetitude player turns</param>
    public void _Turn(float iTurnFactor)
    {
        transform.Rotate(_turnAxis * iTurnFactor * _turnSpeed);
    }
}
