using Controls;
using UnityEngine;

public abstract class BaseWorldState : MonoBehaviour
{
    protected readonly World _world;
    protected readonly ActionsCommandsScheme _actionsCommandsScheme;
    protected readonly IStationStateSwitcher _stateSwitcher;
    
    protected BaseWorldState(World world,ActionsCommandsScheme actionsCommandsScheme, IStationStateSwitcher stationStateSwitcher)
    {
        
    }

    public abstract void LoadConfig();
    public abstract void Enter();
    public abstract void Exit();
}
