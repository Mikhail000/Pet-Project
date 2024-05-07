//using UnityEngine.InputSystem;
//using UnityEngine;
//
//[CreateAssetMenu(menuName = "SelectionSystem/Commands/AdditiveSelectionCommand")]
//
//public class AdditiveSelectionCommand : BaseCommand
//{
//    public override void Execute(InputAction action, IInputService service)
//    {
//        
//        if (action.IsPressed())
//        {
//            service.AdditiveModifier = true;
//        }
//
//        if (action.WasReleasedThisFrame())
//        {
//            service.AdditiveModifier = false;
//        }
//    }
//}
