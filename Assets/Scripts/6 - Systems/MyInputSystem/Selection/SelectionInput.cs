using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SelectionInput : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private RectTransform selectionBox;
    [SerializeField] private LayerMask UnitLayers;
    [SerializeField] private float dragDelay = 0.1f;
    
    private Vector2 _startMousePosition;
    private float _mouseDownTime;
    
    private void Update()
    {
        HandleSelectionInput();
    }

    public void HandleInput()
    {
        
    }
    
    public void HandleSelectionInput()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) // Мы зажали кнопку
        {
            selectionBox.sizeDelta = Vector2.zero;
            selectionBox.gameObject.SetActive(true);
            _startMousePosition = Input.mousePosition;
            _mouseDownTime = Time.time;
        }
        else if(Input.GetKey(KeyCode.Mouse0) && _mouseDownTime + dragDelay < Time.time) // Если все еще зажата и прошло ли нужное время
        {
            ResizeSelectionBox();
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            selectionBox.sizeDelta = Vector2.zero;
            selectionBox.gameObject.SetActive(false);
            
            if (Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition), out RaycastHit hit, UnitLayers) 
                && hit.collider.TryGetComponent(out SelectableComponent unit))
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    if (SelectionManager.Instance.IsSelected(unit))
                    {
                        SelectionManager.Instance.DeselectUnit(unit);
                    }
                    else
                    {
                        SelectionManager.Instance.Select(unit);
                    }
                }
                else
                {
                    SelectionManager.Instance.DeselectedAll();
                    SelectionManager.Instance.Select(unit);
                }
            }
            else if (_mouseDownTime + dragDelay > Time.time)
            {
                SelectionManager.Instance.DeselectedAll();
            }

            _mouseDownTime = 0;
        }
    }

    private void ResizeSelectionBox()
    {
        float width = Input.mousePosition.x - _startMousePosition.x;
        float heigth = Input.mousePosition.y - _startMousePosition.y;

        selectionBox.anchoredPosition = _startMousePosition + new Vector2(width / 2, heigth / 2);
        selectionBox.sizeDelta = new Vector2(MathF.Abs(width), MathF.Abs(heigth));

        Bounds bounds = new Bounds(selectionBox.anchoredPosition, selectionBox.sizeDelta);

        for (int i = 0; i < SelectionManager.Instance.AvailableUnits.Count; i++)
        {
            if (IsUnitInBox(camera.WorldToScreenPoint(SelectionManager.Instance.AvailableUnits[i].transform.position), bounds))
            {
                SelectionManager.Instance.Select(SelectionManager.Instance.AvailableUnits[i]);
            }
            else
            {
                SelectionManager.Instance.DeselectUnit(SelectionManager.Instance.AvailableUnits[i]);
            }
        }
    }

    private bool IsUnitInBox(Vector2 position, Bounds bounds)
    {
        return position.x > bounds.min.x && position.x < bounds.max.x 
                                         && position.y > bounds.min.y && position.y < bounds.max.y;
    }
}
