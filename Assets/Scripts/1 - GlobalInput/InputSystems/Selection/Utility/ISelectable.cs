using UnityEngine;

public interface ISelectable<T> where T : IEntity
{
    GameObject gameObject { get; }
    bool Selected { get; }
    bool Hovering { get; }
    void Select();
    void Deselect();
    void HoverEnter();
    void HoverExit();
}
