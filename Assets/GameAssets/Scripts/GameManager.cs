using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
/// <summary>
/// this class manages the number input
/// </summary>
public class GameManager : MonoBehaviour
{
    /// <summary>
    /// the events to trigger when ever a numpad pressed
    /// </summary>
    [SerializeField] UnityEvent Num1Clicked;
    [SerializeField] UnityEvent Num2Clicked;
    [SerializeField] UnityEvent Num3Clicked;
    private void Start()
    {
        // default input set is numpad 1
        Num1Clicked?.Invoke();
    }
    /// <summary>
    /// fires a proper triggers whenever a numpad presses
    /// </summary>
    /// <param name="iInputNumber">the number pressed</param>
    public void _NumberClicked( int iInputNumber)
    {
        switch (iInputNumber)
        {
            case 1:
                Num1Clicked?.Invoke();
                break;
            case 2:
                Num2Clicked?.Invoke();
                break;
            case 3:
                Num3Clicked?.Invoke();
                break;
        }
    }
    
    
}
