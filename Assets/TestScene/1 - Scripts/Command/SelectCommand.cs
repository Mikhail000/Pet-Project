using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "SelectionSystem/Commands/SelectCommand")]
public class SelectCommand : BaseCommand
{

    public override void Execute(InputAction action, Selector selector)
    {
        if (action.WasPressedThisFrame())
        {
            selector.StartSelection();
        }

        if (action.IsPressed())
        {
            selector.ContinueSelection();
        }

        if (action.WasReleasedThisFrame())
        {
            selector.ResetSelection();
        }
    }
}
