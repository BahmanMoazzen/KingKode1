using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class PlayerPointAndClickInput : PlayerInputAbstract
{
    [Range(1,300)]
    [SerializeField] float _maxDistance = 200f;
    [SerializeField] LayerMask _groundMask;
    NavMeshAgent _agent;
    Camera _mainCam;
    private void Start()
    {
        _mainCam = Camera.main;
        _agent = GetComponent<NavMeshAgent>();
    }
    protected void OnEnable()
    {
        _input.Player.MouseClicked.performed += MouseClicked_performed;
    }
    protected void OnDisable()
    {
        _input.Player.MouseClicked.performed -= MouseClicked_performed;
    }
    private void MouseClicked_performed(InputAction.CallbackContext obj)
    {
        RaycastHit hitInfo;
        Physics.Raycast(_mainCam.ScreenPointToRay(Mouse.current.position.ReadValue())
            ,out hitInfo, _maxDistance, _groundMask);
        if(hitInfo.collider != null)
        {
            _agent.SetDestination(hitInfo.point);
        }
        
    }

    protected override void _DoInput()
    {
        //Debug.Log(Mouse.current.position.ReadValue());
    }
}
