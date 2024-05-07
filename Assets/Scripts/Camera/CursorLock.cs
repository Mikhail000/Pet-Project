using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class CursorLock : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _lockedText = default;

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
        if (_lockedText)
            _lockedText.text = string.Empty;
    }

    private void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame || GameData.Instance.Input.Provider.PanCamera)
            Cursor.lockState = CursorLockMode.None;
        else if (Mouse.current.leftButton.wasPressedThisFrame || GameData.Instance.Input.Provider.PanCameraUp)
            Cursor.lockState = CursorLockMode.Confined;

        if (_lockedText)
            _lockedText.text = Cursor.lockState == CursorLockMode.Confined
                ? "Press <b><color=#ffa200> Escape </color></b> to Unlock Cursor"
                : string.Empty;
    }
}