using System;
using UnityEngine;

public abstract class SelectionReceiver<T> : MonoBehaviour, ISelectionReceiver where T : IEntity
{
    protected bool selected; 
    protected bool hovering;

    public abstract bool Selected { get; set; }
    public abstract bool Hovering { get; set; }
    public Action OnSelect = delegate { };
    public Action OnDeselect = delegate { };
    public Action OnHoverEnter = delegate { };
    public Action OnHoverExit = delegate { };

    public virtual void Select()
    {
        if (!Selected)
        {
            Selected = true;
            OnSelect();
        }
    }

    public virtual void Deselect()
    {
        if (Selected)
        {
            Selected = false;
            OnDeselect();
        }
    }

    public virtual void HoverEnter()
    {
        Hovering = true;
        OnHoverEnter();
    }

    public virtual void HoverExit()
    {
        Hovering = false;
        OnHoverExit();
    }
    
    //public abstract void Select();
    //public abstract void Deselect();
    //public abstract void HoverEnter();
    //public abstract void HoverExit();

    /* public abstract void Select()
    {
        if (Selected) return;
        Selected = true;
        OnSelect();
    }

    public abstract void Deselect()
    {
        if (Selected == false) return;
        Selected = false;
        OnDeselect();
    }

    public abstract void HoverEnter()
    {
        Hovering = true;
        OnHoverEnter();
    }

    public abstract void HoverExit()
    {
        Hovering = false;
        OnHoverExit();
    } */
}
