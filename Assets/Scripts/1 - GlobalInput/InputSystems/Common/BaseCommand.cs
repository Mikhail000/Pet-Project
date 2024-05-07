using UnityEngine;
using UnityEngine.InputSystem;


public abstract class BaseCommand : ScriptableObject
{
    public abstract void Execute(InputAction action, IInputService service);
}
