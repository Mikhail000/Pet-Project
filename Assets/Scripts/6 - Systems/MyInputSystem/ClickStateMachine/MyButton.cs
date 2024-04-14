using System;
using Unity.VisualScripting;
using UnityEngine;

public class MyButton : MonoBehaviour
{
    [SerializeField] private ButtonBehavior buttonBehavior;

    private void Start()
    {
        buttonBehavior.SwitchState<ReleasedButtonState>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            buttonBehavior.SwitchState<PressedClickState>();
        
        if (Input.GetKeyUp(KeyCode.Mouse0))
            buttonBehavior.SwitchState<ReleasedButtonState>();
    }
    
}
