using UnityEngine;

[CreateAssetMenu]
public class SelectorData : ScriptableObject
{
    [field:SerializeField] public InputSettings Input { get; private set; } = default;
    [field:SerializeField] public PhysicsSettings Physics { get; private set; } = default;
    
    private static SelectorData _instance = default;
    public static SelectorData Instance
    {
        get
        {
            if (_instance == null) 
                _instance = Resources.Load<SelectorData>(nameof(SelectorData));
            return _instance;    
        }
    }
}
