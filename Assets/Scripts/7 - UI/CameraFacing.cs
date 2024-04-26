using UnityEngine;

public class CameraFacing : MonoBehaviour
{
    private static Camera Camera => GameData.Instance.Input.Provider.Camera;
    private Transform _cameraAnchor;
    private Transform _localTransform;

    private void Start()
    {
        _localTransform = GetComponent<RectTransform>();
        _cameraAnchor = Camera.transform.parent.GetComponentInParent<Transform>();
    }

    private void Update()
    {
        if (_cameraAnchor)
        {
            _localTransform.LookAt(2 * _localTransform.position - _cameraAnchor.position);
        }
    }
}