using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Barrack : SelectionReceiver<IBuilding>
{
    [SerializeField] private GameObject healthBar;
    [SerializeField] private Canvas canvas;


    public override bool Selected { get; set; }
    public override bool Hovering { get; set; }

    public override void Select()
    {
        throw new NotImplementedException();
    }

    public override void Deselect()
    {
        throw new NotImplementedException();
    }

    public override void HoverEnter()
    {
        throw new NotImplementedException();
    }

    public override void HoverExit()
    {
        throw new NotImplementedException();
    }
}
