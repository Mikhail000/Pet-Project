using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace InputSystem
{
    public class SpectateWorldState : BaseInputState, IDisposable
    {
        private InputLayout _inputLayout;
        private Selector _selector;
        private SelectionReader _selectionReader;

        public SpectateWorldState(IStationStateSwitcher switcher, InputLayout inputLayout, Selector selector)
            : base(switcher)
        {
            _inputLayout = inputLayout;
            _selector = selector;
        }

        public override void InitState()
        {
            _selectionReader = new SelectionReader(_inputLayout);
            _selector.SubscribeEvents(_selectionReader);
        }

        public override void Enter()
        {
            _selectionReader.EnableMap();
        }

        public override void Exit()
        {
            _selectionReader.DisableMap();

        }

        public void Dispose()
        {
            //_input.Dispose();
        }
    }
}