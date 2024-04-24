using System;
using UnityEngine;

[Serializable]
public class WorldUICanvasSettings : ISerializationCallbackReceiver
{
    [field:SerializeField] public Canvas WorldCanvas { get; private set; }

    private Canvas _worldCanvas = default;
    
    public void OnBeforeSerialize()
    {
        WorldCanvas = _worldCanvas;
    }

    public void OnAfterDeserialize()
    {
        _worldCanvas = WorldCanvas;
    }
}
