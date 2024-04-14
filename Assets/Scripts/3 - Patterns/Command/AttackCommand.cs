using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCommand : Command
{
    private AttackTarget _attackTarget;
    
    private UnitStackController _unitStackController;

    public AttackCommand(AttackTarget attackTarget, UnitStackController unitStackController)
    {
        _attackTarget = attackTarget;
    }
    
    public override void Execute()
    {
        
    }

    public override void Undo()
    {
        throw new System.NotImplementedException();
    }
}
