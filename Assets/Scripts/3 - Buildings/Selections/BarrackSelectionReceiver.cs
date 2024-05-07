using System;
using UnityEngine;

public class BarrackSelectionReceiver : SelectionReceiver<IBuilding>, IBuilding
{
    public override bool Selected
    {
        get { return selected;}
        set { selected = value; }

    }
    public override bool Hovering
    {
        get { return hovering; }
        set { hovering = value; }
    }
    
    public override void Select()
    {
        base.Select();
        if (Selected) return;
        Selected = true;
        OnSelect();
    }

    public override void Deselect()
    {
        if (Selected == false) return;
        Selected = false;
        OnDeselect();
    }

    public override void HoverEnter()
    {
        Hovering = true;
        OnHoverEnter();
    }

    public override void HoverExit()
    {
        Hovering = false;
        OnHoverExit();
    }
}
