using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "SelectionSystem/Commands/SelectCommand")]
public class SelectCommand : BaseCommand
{

    public override void Execute(InputAction action, Selector selector)
    {
        if (action.IsPressed())
        {
            selector.SelectObject();
        }
    }
}
