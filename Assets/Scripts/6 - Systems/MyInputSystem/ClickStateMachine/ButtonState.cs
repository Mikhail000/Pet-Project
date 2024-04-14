public abstract class ButtonState
{
    protected readonly MyButton _button;
    protected readonly IStationStateSwitcher _stationStateSwitcher;
    protected ButtonState(MyButton button, IStationStateSwitcher stationStateSwitcher)
    {
        _button = button;
        _stationStateSwitcher = stationStateSwitcher;
    }

    public abstract void Enter();

    public abstract void Exit();
}
