using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    public void MoveOn(InputAction.CallbackContext iContext)
    {
        if (iContext.started)
        {
            Debug.Log("test");

        }

    }
}
