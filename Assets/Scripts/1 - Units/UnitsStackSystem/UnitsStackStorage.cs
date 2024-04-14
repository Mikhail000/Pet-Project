using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitsStackStorage : MonoBehaviour
{
    private List<Unit> _unitStack = new List<Unit>();

    public List<Unit> UnitsStackData
    {
        get => _unitStack;
        set => _unitStack = value;
    }

    public void FillStack(List<Unit> takenStack)
    {
        _unitStack = takenStack;
    }
    public void Reset()
    {
        _unitStack.Clear();
    }
}
