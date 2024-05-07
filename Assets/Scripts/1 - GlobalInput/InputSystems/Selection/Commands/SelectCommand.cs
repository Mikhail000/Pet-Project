using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "SelectionSystem/Commands/SelectCommand")]
public class SelectCommand : BaseCommand
{
    public override void Execute(InputAction action, IInputService service)
    {
        
        if (action.WasPressedThisFrame() && action.WasPressedThisFrame())
        {
            service.OnPress();
        }

        if (action.WasReleasedThisFrame())
        {
            service.OnRelease();
        }
    }
}
