using UnityEngine;

public class OnCameraMove 
{
    public readonly Vector3 Position;
    public readonly Quaternion Rotation;
    public readonly Vector3 EulerAngles;

    public OnCameraMove(Vector3 position, Quaternion rotation, Vector3 eulerAngles)
    {
        Position = position;
        Rotation = rotation;
        EulerAngles = eulerAngles;
    } 
}
