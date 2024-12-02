using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] UnityEvent Num1Clicked;
    [SerializeField] UnityEvent Num2Clicked;
    [SerializeField] UnityEvent Num3Clicked;
    private void Start()
    {
        Num1Clicked?.Invoke();
    }
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
