using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController _controller;
    [SerializeField] float _moveSpeed;
    [SerializeField] float _sideSpeed;
    [SerializeField] float _turnSpeed;
    [SerializeField] Vector3 _turnAxis = new Vector3(0, 1, 0);
    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }
    public void _MoveForward(float iForwardFactor)
    {
        _controller.Move(transform.forward * _moveSpeed * iForwardFactor);
    }
    public void _MoveSide(float iSideFactor)
    {
        _controller.Move(transform.right * _sideSpeed * iSideFactor);
    }
    public void _Turn(float iTurnFactor)
    {
        transform.Rotate(_turnAxis * iTurnFactor * _turnSpeed);
    }
}
