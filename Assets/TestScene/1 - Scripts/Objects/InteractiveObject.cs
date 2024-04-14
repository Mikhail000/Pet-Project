using UnityEngine;

public abstract class InteractiveObject : MonoBehaviour, IInteractable
{
    public abstract void Select();
    public abstract void Deselect();
}