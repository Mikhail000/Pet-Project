public interface IStationStateSwitcher 
{
    void SwitchState<T>() where T : BaseInputState;
}
