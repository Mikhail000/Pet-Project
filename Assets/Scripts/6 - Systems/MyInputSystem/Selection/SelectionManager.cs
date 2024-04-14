using System.Collections.Generic;
using UnityEngine;

public class SelectionManager
{
    
    private static SelectionManager _instance;
    public static SelectionManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SelectionManager();
            }

            return _instance;
        }
        private set
        {
            _instance = value;
        }
    }
    
    public HashSet<SelectableComponent> SelectedUnits = new HashSet<SelectableComponent>();
    public List<SelectableComponent> AvailableUnits = new List<SelectableComponent>();
    
    public void Select(SelectableComponent unit)
    {
        SelectedUnits.Add(unit);
        unit.OnSelect();
    }

    public void DeselectUnit(SelectableComponent unit)
    {
        SelectedUnits.Remove(unit);
        unit.OnDeselect();
    }

    public void DeselectedAll()
    {
        foreach (SelectableComponent unit in SelectedUnits)
        {
            unit.OnDeselect();
        }
        SelectedUnits.Clear();
    }

    public bool IsSelected(SelectableComponent unit)
    {
        return SelectedUnits.Contains(unit);
    }
}
