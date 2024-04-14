using UnityEngine;

public class PressedClickState : ButtonState
{
    public PressedClickState(MyButton button, IStationStateSwitcher stationStateSwitcher) : base(button, stationStateSwitcher)
    {
    }

    public override void Enter()
    {
        GlobalEventBus.InputSystemBus.Invoke(new ButtonPressed());
        Debug.Log("Enter in PRESSED STATE");
    }

    public override void Exit()
    {
        Debug.Log("Exit from PRESSED STATE");
    }
}
