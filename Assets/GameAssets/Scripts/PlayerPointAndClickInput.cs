using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
/// <summary>
/// This class implements the Point-And-Click functionality of the player
/// </summary>
public class PlayerPointAndClickInput : PlayerInputAbstract
{
    /// <summary>
    /// The raycast max distance
    /// </summary>
    [Range(1,300)]
    [SerializeField] float _maxDistance = 200f;
    /// <summary>
    /// The Ground LayerMask
    /// </summary>
    [SerializeField] LayerMask _groundMask;
    /// <summary>
    /// NaveMeshAgent to move the player using unity AI
    /// </summary>
    NavMeshAgent _agent;
    /// <summary>
    /// The main camera by which the raycasting happens
    /// </summary>
    Camera _mainCam;
    private void Start()
    {
        // Getting required components
        _mainCam = Camera.main;
        _agent = GetComponent<NavMeshAgent>();
    }
    protected void OnEnable()
    {
        // Listening to the click input
        _input.Player.MouseClicked.performed += MouseClicked_performed;
    }
    protected void OnDisable()
    {
        // Unregistering from the click input
        _input.Player.MouseClicked.performed -= MouseClicked_performed;
    }
    /// <summary>
    /// This method implements the click and moving towards it
    /// </summary>
    /// <param name="iContext">Extra information about the click</param>
    private void MouseClicked_performed(InputAction.CallbackContext iContext)
    {
        // Checks whether the click is performed completely
        if (iContext.performed)
        {
            // Raycasting from main camera
            RaycastHit hitInfo;
            Physics.Raycast(_mainCam.ScreenPointToRay(Mouse.current.position.ReadValue())
                , out hitInfo, _maxDistance, _groundMask);
            // Chekh whether it hits the ground
            if (hitInfo.collider != null)
            {
                // Setting agent to move towards the contact point
                _agent.SetDestination(hitInfo.point);
            }
        }
        
    }
    /// <summary>
    /// Does nothing
    /// </summary>
    protected override void _DoInput()
    {
        //Debug.Log(Mouse.current.position.ReadValue());
    }
}
