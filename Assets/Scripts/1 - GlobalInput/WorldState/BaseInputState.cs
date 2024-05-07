using System;
using Unity.Services.Core;
using UnityEngine;

public abstract class BaseInputState
{
    
    protected BaseInputState(IStationStateSwitcher switcher)
    {
        
    }

    public abstract void InitState();
    public abstract void Enter();
    public abstract void Exit();
    
}
