using System;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

public class RaycastHandler : MonoBehaviour // Посылаем луч покадрово
{
    [Space, Header("Ray Settings")]
    [SerializeField] private float rayDistance = 0f;
    [SerializeField] private float raySphereRadius = 0f;
    [SerializeField] private LayerMask interactableLayer = ~0;
    
    [Space, Header("Raycasting Object Transform Data")]
    [SerializeField] private RaycastHitObjectData raycastHitObjectData;

    private SelectableComponent _hittedObject;
    private Camera _cam;
    private Vector3 _mousePos;
    private Transform _objTransform;
    private bool _hitSomething;
    private bool _isSameObject;

    private void Awake()
    {
        _cam = FindObjectOfType<Camera>();
    }

    private void Update()
    {
        Raycasting();
    }

    private void Raycasting()
    {
        _mousePos = Input.mousePosition;
        _mousePos.z = 100f;
        _mousePos = _cam.ScreenToWorldPoint(_mousePos);
        var position = transform.position;
        
        Ray _ray = new Ray(position,_mousePos - position);
        RaycastHit _hitInfo;

        _hitSomething = Physics.SphereCast(_ray,raySphereRadius, out _hitInfo, rayDistance, interactableLayer);

        if (_hitSomething)
        {
            CheckHittedObjectIsSame(_hitInfo);
        }
        
        Debug.DrawRay(_ray.origin,_ray.direction * rayDistance,_hitSomething ? Color.green : Color.red);
    }
    
    private void CheckHittedObjectIsSame(RaycastHit hittedObj) // Функция предотвращающая постоянное "запихивание" объекта в "дату"
    {
        var hasComponent = hittedObj.transform.TryGetComponent(out SelectableComponent obj); // Проверили, есть ли IInteractable
        if (hasComponent) // +
        {
            if (!obj.Equals(raycastHitObjectData.Interactable)) // Если IInteractable того же объекта, останавливаем цикл
            {
                SaveHittedbject(obj);
            }
        }
        else
        {
            return;
        }
    }
    
    private void SaveHittedbject(SelectableComponent comp)
    {
        raycastHitObjectData.Interactable = comp;
    }
}
