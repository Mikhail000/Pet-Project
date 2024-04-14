using UnityEngine;

public class ReleasedButtonState : ButtonState
{
    public ReleasedButtonState(MyButton button, IStationStateSwitcher stationStateSwitcher) : base(button, stationStateSwitcher)
    {
    }

    public override void Enter()
    {
        GlobalEventBus.InputSystemBus.Invoke(new ButtonReleased());
        Debug.Log("Enter in RELEASE STATE");
    }

    public override void Exit()
    {
        Debug.Log("Exit from RELEASE STATE");
    }
}
