using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UIElements;

[Serializable]
public class InputSettings
{
    [SerializeReference] public IInputProvider Provider = new PCInput();

    [ContextMenu("Reset")]
    private void Reset() => Provider = new PCInput();
}

public interface IInputProvider
{
    Camera Camera { get; }
    
    bool PanCamera { get; }
    bool PanCameraDown { get; }
    bool PanCameraUp { get; }
    
    bool CameraRotationModifier { get; }
    bool CameraRotationModifierUp { get; }
}

[Serializable]
public class PCInput : IInputProvider
{
    [Header("PC Input")]
    
    [SerializeField] private MouseButton _panCamera = MouseButton.MiddleMouse;
    [SerializeField] private KeyCode _cameraRotationModifier = KeyCode.LeftAlt;
    
    public Camera Camera => Camera.main;
    
    public bool PanCamera => Input.GetMouseButton((int)_panCamera);
    public bool PanCameraDown => Input.GetMouseButtonDown((int)_panCamera);
    public bool PanCameraUp => Input.GetMouseButtonUp((int)_panCamera);
    public bool CameraRotationModifier => Input.GetKey(_cameraRotationModifier);
    public bool CameraRotationModifierUp => Input.GetKeyUp(_cameraRotationModifier);
}
