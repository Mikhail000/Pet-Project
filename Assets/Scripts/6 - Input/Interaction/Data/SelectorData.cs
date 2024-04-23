using UnityEngine;

[CreateAssetMenu]
public class SelectorData : ScriptableObject
{
    [field: SerializeField] public PhysicsSettings Physics { get; private set; } = default;
    [field: SerializeField] public InputSettings Input { get; private set; } = default;

    [field: SerializeField] public ColorSettings Color { get; private set; } = default;

    private static SelectorData _instance = default;

    public static SelectorData Instance
    {
        get
        {
            if (_instance == null)
                _instance = Resources.Load<SelectorData>(nameof(SelectorData));
                //_instance = Resources.Load<SelectorData>("Assets/TestScene/5-ScriptableObjects/SelectorData.asset");
            return _instance;
        }
    }
}