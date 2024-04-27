using UnityEngine.InputSystem;
using UnityEngine;

[CreateAssetMenu(menuName = "SelectionSystem/Commands/AdditiveSelectionCommand")]

// <summary>
// Комманда для добавление юнитов через SHIFT
// <summary>
public class AdditiveSelectionCommand : BaseCommand
{
    public override void Execute(InputAction action, Selector selector)
    {
        if (action.IsPressed())
        {
            selector.AdditiveModifier = true;
        }

        if (action.WasReleasedThisFrame())
        {
            selector.AdditiveModifier = false;
        }
    }
}
