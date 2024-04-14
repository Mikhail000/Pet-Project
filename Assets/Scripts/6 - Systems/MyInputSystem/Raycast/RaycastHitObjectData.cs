using System;
using UnityEngine;

[CreateAssetMenu(fileName = "RaycastHitObjectData", menuName = "RaycastHitObjectData")]
public class RaycastHitObjectData : ScriptableObject
{
    private InteractableComponent _interactableComponent;

    private SelectableComponent _interactableObject;

    public InteractableComponent InteractableComponent
    {
        get => _interactableComponent;
        set => _interactableComponent = value;
    }

    public SelectableComponent Interactable
    {
        get => _interactableObject;
        set => _interactableObject = value;
    }

    public void Reset() => InteractableComponent = null;
}
