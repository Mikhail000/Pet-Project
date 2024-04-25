using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraParameters : MonoBehaviour
{
    private static Camera Camera => GameData.Instance.Input.Provider.Camera;

    private static CameraParameters _instance = default;
    
    public static CameraParameters Instance
    {
        get
        {
            if (_instance == null)
                _instance = Resources.Load<CameraParameters>(nameof(CameraParameters));
            return _instance;
        }
    }
}
