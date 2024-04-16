using System;
using Unity.VisualScripting;
using UnityEngine;

// <summary>
// Это должно быть на главной камере
// <summary>
public class Selector : MonoBehaviour
{
    [SerializeField] private float rayDistance = 0f;
    [SerializeField] private LayerMask interactableLayer = ~0;
    
    private Camera _camera;
    private Vector3 _mousePos;
    private bool _hitSomething;

    private void Start()
    {
        _camera = GetComponent<Camera>();
    }

    public void SelectObject()
    {
        _mousePos = Input.mousePosition;
        _mousePos.z = 100f;
        _mousePos = _camera.ScreenToWorldPoint(_mousePos);
        var position = transform.position;
        
        Ray _ray = new Ray(position,_mousePos - position);
        RaycastHit _hitInfo;
        
        Debug.DrawRay(_ray.origin,_ray.direction * rayDistance,_hitSomething ? Color.green : Color.red);
        
        //RaycastHit hit;
        //Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        //{
        //    if (Physics.Raycast(ray, out hit, Mathf.Infinity, interactableLayer))
        //    {
        //        
        //    }
        //}
    }
}
