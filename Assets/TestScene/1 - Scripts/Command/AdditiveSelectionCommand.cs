using UnityEngine.InputSystem;
using UnityEngine;

[CreateAssetMenu(menuName = "SelectionSystem/Commands/AdditiveSelectionCommand")]
public class AdditiveSelectionCommand : BaseCommand
{
    public override void Execute(InputAction action, Selector selector)
    {
        if (action.IsPressed())
        {
            
        }
    }
}
