using UnityEngine;

public class RaycastHitEvent
{
    public readonly Transform ObjTransform;

    public readonly InteractableComponent InteractableComponent;

    public RaycastHitEvent(Transform objTransform, InteractableComponent interactableComponent)
    {
        ObjTransform = objTransform;
        InteractableComponent = interactableComponent;
    }
}
