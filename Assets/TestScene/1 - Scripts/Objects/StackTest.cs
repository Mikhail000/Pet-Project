using System.Collections.Generic;
using UnityEngine;

public class StackTest : InteractiveObject
{
    [SerializeField] private List<Human> manStack = new List<Human>();
    
    
    public override void Select()
    {
        // тут конкретная реализация с перечислением массива и включением
    }

    public override void Deselect()
    {
        // тут конкретная реализация с перечислением массива и отключением
    }
}
