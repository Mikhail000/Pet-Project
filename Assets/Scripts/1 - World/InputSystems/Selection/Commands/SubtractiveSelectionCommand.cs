using UnityEngine.InputSystem;
using UnityEngine;

[CreateAssetMenu(menuName = "SelectionSystem/Commands/SubtractiveSelectionCommand")]
public class SubtractiveSelectionCommand : BaseCommand
{
    public override void Execute(InputAction action, Selector selector)
    {
        if (action.IsPressed())
        {
            selector.SubtractiveModifier = true;
        }
        if (action.WasReleasedThisFrame())
        {
            selector.SubtractiveModifier = false;
        }
    }
}
