using System;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem.UI;


public class CameraDirectionalMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;
    private static Vector3 InputDirection => new(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    private Transform _transform;
    private Vector3 _cameraPosition;
    private Vector3 _cameraEuler;
    private Quaternion _cameraRotation;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        var movementDirection = Quaternion.Euler(0, transform.localEulerAngles.y, 0) * InputDirection;
        transform.Translate(movementDirection * _moveSpeed * Time.deltaTime, Space.World);
        _cameraPosition = _transform.position;
        _cameraRotation = _transform.rotation;
        _cameraEuler = _transform.eulerAngles;
        GlobalEventBus.CameraBus.Invoke(new OnCameraMove(_cameraPosition, _cameraRotation, _cameraEuler));
    }
}