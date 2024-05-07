using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// ЧТО-ТО ТИПО КЛАССА-ПРОКЛАДКИ ДЛЯ ПРЕДСТАВЛЕНИЯ ACTIONMAP

namespace InputSystem
{
    public class SelectionReader : InputLayout.ISpectateMapActions, IReader
    {
        private InputLayout _input;

        public event Action SelectPressEvent;
        public event Action SelectReleaseEvent;
        
        public event Action AdditivePressEvent;
        public event Action AdditiveReleaseEvent;
        
        public event Action SubsractPressEvent;
        public event Action SubsractReleaseEvent;


        public SelectionReader(InputLayout inputLayout)
        {
            _input = inputLayout;
            _input.SpectateMap.SetCallbacks(this);
        }

        public void EnableMap()
        {
            _input.SpectateMap.Enable();

        }

        public void DisableMap()
        {
            _input.SpectateMap.Disable();
        }

        public void OnSelect(InputAction.CallbackContext context)
        {
            if (context.phase == InputActionPhase.Performed)
            {
                SelectPressEvent?.Invoke();
            }

            if (context.phase == InputActionPhase.Canceled)
            {
                SelectReleaseEvent?.Invoke();
            }
        }

        public void OnAdditive(InputAction.CallbackContext context)
        {
            if (context.phase == InputActionPhase.Performed)
            {
                AdditivePressEvent?.Invoke();
            }

            if (context.phase == InputActionPhase.Canceled)
            {
                AdditiveReleaseEvent?.Invoke();
            }
        }

        public void OnSubtract(InputAction.CallbackContext context)
        {
            if (context.phase == InputActionPhase.Performed)
            {
                SubsractPressEvent?.Invoke();
            }

            if (context.phase == InputActionPhase.Canceled)
            {
                SubsractReleaseEvent?.Invoke();
            }
        }
    }
}