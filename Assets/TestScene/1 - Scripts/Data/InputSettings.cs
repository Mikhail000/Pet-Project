using System;
using UnityEngine;

[Serializable]
public class InputSettings
{
    [SerializeReference] public IInputProvider Provider = new PCInput();

    [ContextMenu("Reset")]
    private void Reset() => Provider = new PCInput();
}

public interface IInputProvider
{
    Camera Camera { get; }
    
}

public class PCInput : IInputProvider
{
    public Camera Camera => Camera.main;
}
