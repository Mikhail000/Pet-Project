using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "SelectionSystem/Commands/SelectiCommand")]
public class SelectCommand : BaseCommand
{
    public override void Execute(InputAction action, Selector selector)
    {
        if (action.WasPressedThisFrame())
        {
            selector.StartSelection();
        }

        if (action.WasReleasedThisFrame())
        {
            selector.EndSelection();
        }
    }
}
