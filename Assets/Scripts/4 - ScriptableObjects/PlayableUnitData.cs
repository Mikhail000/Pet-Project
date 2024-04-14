using UnityEngine;

[CreateAssetMenu(fileName = "UnitsStorage", menuName = "UnitsStorage")]
public class PlayableUnitData : ScriptableObject
{
    public PlayableUnitIDs UnitNamespace;
    [Space(5)]
    public double Health;
    [Space(5)]
    public double HitPower;
    public AttackTypesIDs AttackType;
    [Space(5)]
    public double Velocity;
}
