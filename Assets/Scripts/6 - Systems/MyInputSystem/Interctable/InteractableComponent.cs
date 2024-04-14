using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableComponent : MonoBehaviour
{
    [Space,Header("Interactable Settings")]
    
    [Space] 
    [SerializeField] private bool isInteractable = true;
    
    [Space] 
    [SerializeField] private bool holdInteract = true;
    [SerializeField] private double holdDuration = 0f;
            
    [Space] 
    [SerializeField] private bool multipleUse = false;
    
    
    public double HoldDuration => holdDuration; 
    public bool HoldInteract => holdInteract;
    public bool MultipleUse => multipleUse;
    public bool IsInteractable => isInteractable;
}
