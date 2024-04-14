using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command
{
    private readonly Vector3 _currentPos;
    private readonly Vector3 _dirPos;

    private UnitStackController _unitStackController;

    public MoveCommand(Vector3 currentPos, Vector3 dirPos, UnitStackController unitStackController)
    {
        _currentPos = currentPos;
        _dirPos = dirPos;
        _unitStackController = unitStackController;
    }
    
    public override void Execute()
    {
        
    }

    public override void Undo()
    {
        throw new System.NotImplementedException();
    }
}
