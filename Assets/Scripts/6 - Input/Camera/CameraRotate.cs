using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [SerializeField] private float _sensitivity = 200f;
    private static bool RotationMod => SelectorData.Instance.Input.Provider.CameraRotationModifier;
    private static bool RotationModUp => SelectorData.Instance.Input.Provider.CameraRotationModifierUp;

    private void Update()
    {
        UpdateCursorVisibility();
        Rotate();
    }

    private void Rotate()
    {
        if (RotationMod == false) return;
        var xRotation = Input.GetAxis("Mouse X") * _sensitivity * Time.deltaTime;
        transform.Rotate(0, xRotation, 0, Space.World);
    }

    private static void UpdateCursorVisibility()
    {
        if (RotationMod) Cursor.visible = false;
        else if (RotationModUp) Cursor.visible = true;
    }
}