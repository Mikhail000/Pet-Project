using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace InputSystem
{
    public class InputSystemStationBehaviour : MonoBehaviour, IStationStateSwitcher
    {
        private InputLayout _input;

        [SerializeField] private Selector selector;
        [SerializeField] private SelectedUnitsController unitsController;

        private BaseInputState _currentState;
        private List<BaseInputState> _allStates;

        private void Awake()
        {
            _input = new InputLayout();
            _input.Enable();

            _allStates = new List<BaseInputState>()
            {
                new SpectateWorldState(this, _input, selector)
            };
            _currentState = _allStates[0];
            _currentState.InitState();
        }

        public void SwitchState<T>() where T : BaseInputState
        {
            var state = _allStates.FirstOrDefault(s => s is T);
            _currentState = state;
        }
    }
}
