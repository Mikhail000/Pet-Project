using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WorldStationBehaviour : MonoBehaviour, IStationStateSwitcher
{
    [SerializeField] private World world;

    private BaseWorldState _currentState;
    private List<BaseWorldState> _allStates;

    public void Initialize()
    {
        
    }
    
    private void Start()
    {
        _allStates = new List<BaseWorldState>();



    }

    public void SwitchState<T>() where T : BaseWorldState
    {
        var state = _allStates.FirstOrDefault(s => s is T);
        _currentState = state;
    }
}
