using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Barrack : MonoBehaviour, ISelectable
{
    [SerializeField] private GameObject healthBar;
    [SerializeField] private Canvas canvas;
    
    public bool Selected { get; }
    public bool Hovering { get; }

    private void Start()
    {
        
    }


    public void Select()
    {
        ShowMenu();
    }
    public void Deselect()
    {
        
    }
    public void HoverEnter()
    {
        
    }
    public void HoverExit()
    {
        
    }
    private void ShowMenu()
    {
        
    }
    
    
}
