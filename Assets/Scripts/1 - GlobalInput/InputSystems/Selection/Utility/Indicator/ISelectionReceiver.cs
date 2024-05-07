using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISelectionReceiver 
{
    bool Selected { get; set; }
    bool Hovering { get; set; }
    void Select();
    void Deselect();
    void HoverEnter();
    void HoverExit();
}
