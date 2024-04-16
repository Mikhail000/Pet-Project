using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// <summary>
// Это должно быть на главной камере
// <summary>
public class Selector : MonoBehaviour
{
    [SerializeField] private RectTransform selectionImage;
    [SerializeField] private float rayDistance = 0f;
    [SerializeField] private LayerMask interactableLayer = ~0;
    [SerializeField] private List<InteractableComponent> selectedObjects = new List<InteractableComponent>();
    
    private Camera _camera;
    private Vector3 _mousePos;
    private bool _hitSomething;

    private bool isOtherSelections;

    private Rect selectionRect;
    private Vector2 _startPos;
    private Vector2 _endPos;

    private void Start()
    {
        _camera = GetComponent<Camera>();
        ResetSelection();
    }

    public void StartSelection()
    {
        // сохраняем координаты мыши
        _startPos = Input.mousePosition;
        // обрабатываем их в мировом пространстве
        selectionRect = new Rect();
    }

    public void ContinueSelection()
    {
        _endPos = Input.mousePosition;
        DrawRectangle();
    }

    public void ResetSelection()
    {
        _startPos = _endPos = Vector2.zero;
        DrawRectangle();
    }
    
    public bool IsOtherSelection()
    {
        if (selectedObjects != null)
        {
            isOtherSelections = true;
        }
        return false;   
    }
    public void DeselectAll()
    {
        
    }
    public void ConfirmSelection()
    {
        
    }
    private void DrawRectangle()
    {
        Vector2 boxStart = _startPos;
        Vector2 center = (boxStart + _endPos) / 2;

        selectionImage.position = center;

        float sizeX = Math.Abs(boxStart.x - _endPos.x);
        float sizeY = Math.Abs(boxStart.y - _endPos.y);

        selectionImage.sizeDelta = new Vector2(sizeX, sizeY);
    }
    
    
}
