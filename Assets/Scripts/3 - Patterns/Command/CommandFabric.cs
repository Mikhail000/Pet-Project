using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandFabric : MonoBehaviour
{
    [SerializeField] private UnitStackController unitStackController;

    public MoveCommand CreateMoveCommand(Vector3 currentPos, Vector3 directionTarget)
    {
        return new MoveCommand(currentPos, directionTarget, unitStackController);
    }

    public AttackCommand CreateAttackCommand(AttackTarget attackTarget)
    {
        return new AttackCommand(attackTarget, unitStackController);
    }
}
