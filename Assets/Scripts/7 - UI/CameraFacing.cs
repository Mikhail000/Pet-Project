using System;
using UnityEngine;

public class CameraFacing : MonoBehaviour
{
    private Vector3 transEul;
    private void Start()
    {
        transEul = GetComponent<Transform>().eulerAngles;
    }

    private void OnEnable()
    {
        GlobalEventBus.CameraBus.Subscribe<OnCameraMove>(CameraTranslate);
    }
    

    private void CameraTranslate(OnCameraMove signal)
    {
        Vector3 directionToTarget = signal.Position - transform.position;
        
        transform.rotation = Quaternion.LookRotation(new Vector3(-directionToTarget.x, directionToTarget.y, transform.position.z), Vector3.up);
    }
}