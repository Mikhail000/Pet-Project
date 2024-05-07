using System.Collections.Generic;
using System.Linq;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

//<summary>
// Как класс должен работать, принимает объект, узнает тип
// Если первый IUnit, выбираем только объекты IUnit.
// Если первый IBulding, то проверяем нет ли больше объектов IUnit.
// Если есть - выберим их.

public class Separator : MonoBehaviour 
{
    private List<ISelectionReceiver> _list = new List<ISelectionReceiver>();
    
    public void ProcessSelectedObjects(ISelectionReceiver selectedObject)
    {
        // Проверяем, были ли уже выделены объекты
        bool anySelected = _list.Any();
        
        // Если объекты уже были выделены, узнаем их тип
        bool isBuildingSelected = anySelected && _list.OfType<IBuilding>().Any();
        bool isUnitSelected = anySelected && _list.OfType<IUnit>().Any();
        
        
        // Если объекты еще не были выделены, выделяем все IUnit
        if (!anySelected || isBuildingSelected)
        {
            if (selectedObject is IUnit)
            {
                selectedObject.Select();
                _list.Add(selectedObject);
            }
            Debug.Log(isUnitSelected);
        }
        else if (isUnitSelected)
        {
            if (selectedObject is IUnit && !_list.Contains(selectedObject))
            {
                selectedObject.Select();
                _list.Add(selectedObject);
            }
            Debug.Log(isUnitSelected);
        }

        // Выводим типы выделенных объектов
        
        _list.ForEach(e => Debug.Log(e.GetType().ToString()));
    }

    public void ClearSelection()
    {
        _list.Clear();
    }
    
    public void Deselect(ISelectionReceiver selectedObject)
    {
        selectedObject.Deselect();
        _list.Remove(selectedObject);
    }
}