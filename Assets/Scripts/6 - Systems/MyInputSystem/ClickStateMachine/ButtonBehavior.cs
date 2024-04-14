using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour, IStationStateSwitcher
{
    [SerializeField] private MyButton _button;

    private ButtonState _currentState;
    private List<ButtonState> _allStates;

    private void Start()
    {
        _allStates = new List<ButtonState>()
        {
            new PressedClickState(_button, this),
            new ReleasedButtonState(_button, this)
        };
        _currentState = _allStates[0];
    }
    
    public void SwitchState<T>() where T : ButtonState
    {
        var state = _allStates.FirstOrDefault(s => s is T);
        _currentState.Exit();
        state.Enter();
        _currentState = state;
    }
}
