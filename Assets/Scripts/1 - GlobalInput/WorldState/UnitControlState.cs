using System.Collections.Generic;
using UnityEngine;

public class UnitControlState : BaseInputState
{
    private InputLayout _inputLayout;
    private SelectedUnitsController _selectedUnitsController;
    //private UnitControlReader _selectionReader;
    
    public UnitControlState(IStationStateSwitcher switcher, InputLayout inputLayout, SelectedUnitsController selectedUnitsController) 
        : base(switcher)
    {
        _inputLayout = inputLayout;
        _selectedUnitsController = selectedUnitsController;
    }


    public override void InitState()
    {
        
    }

    public override void Enter()
    {
        
    }

    public override void Exit()
    {
        
    }
}
