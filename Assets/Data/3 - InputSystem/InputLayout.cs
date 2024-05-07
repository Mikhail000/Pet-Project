//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Data/3 - InputSystem/InputLayout.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputLayout : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputLayout()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputLayout"",
    ""maps"": [
        {
            ""name"": ""SpectateMap"",
            ""id"": ""b5256882-f7a2-4c13-b3de-41ddd41def94"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""cf807a4b-3fa0-4ee4-8b71-d8c7acf8170e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Additive"",
                    ""type"": ""Button"",
                    ""id"": ""e922d3fb-50bd-4918-bfe0-1667efa07c64"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Subtract"",
                    ""type"": ""Button"",
                    ""id"": ""7f72571f-ded4-4a99-a0bd-caf4b28656aa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""41edb609-295d-4084-a658-c4e98a76e29c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26fecb1b-3d61-4e4f-b4d8-e081e3e11855"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Additive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0817a332-4979-44ea-9b8e-677ff266f55d"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Subtract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UnitControlMap"",
            ""id"": ""606a85f1-88b0-4b7e-a985-948f09f53e36"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""8d80e380-6ecb-47aa-b3ef-6717e48b7c87"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""a1f65fbc-ff05-4d07-b661-15db16a7864f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""493daf91-e7ed-48c9-971a-370ab936e052"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8478dac-0c30-4fa9-8ee0-cf5e51b3f069"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse and Keyboard"",
            ""bindingGroup"": ""Mouse and Keyboard"",
            ""devices"": []
        }
    ]
}");
        // SpectateMap
        m_SpectateMap = asset.FindActionMap("SpectateMap", throwIfNotFound: true);
        m_SpectateMap_Select = m_SpectateMap.FindAction("Select", throwIfNotFound: true);
        m_SpectateMap_Additive = m_SpectateMap.FindAction("Additive", throwIfNotFound: true);
        m_SpectateMap_Subtract = m_SpectateMap.FindAction("Subtract", throwIfNotFound: true);
        // UnitControlMap
        m_UnitControlMap = asset.FindActionMap("UnitControlMap", throwIfNotFound: true);
        m_UnitControlMap_Attack = m_UnitControlMap.FindAction("Attack", throwIfNotFound: true);
        m_UnitControlMap_Move = m_UnitControlMap.FindAction("Move", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // SpectateMap
    private readonly InputActionMap m_SpectateMap;
    private ISpectateMapActions m_SpectateMapActionsCallbackInterface;
    private readonly InputAction m_SpectateMap_Select;
    private readonly InputAction m_SpectateMap_Additive;
    private readonly InputAction m_SpectateMap_Subtract;
    public struct SpectateMapActions
    {
        private @InputLayout m_Wrapper;
        public SpectateMapActions(@InputLayout wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_SpectateMap_Select;
        public InputAction @Additive => m_Wrapper.m_SpectateMap_Additive;
        public InputAction @Subtract => m_Wrapper.m_SpectateMap_Subtract;
        public InputActionMap Get() { return m_Wrapper.m_SpectateMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SpectateMapActions set) { return set.Get(); }
        public void SetCallbacks(ISpectateMapActions instance)
        {
            if (m_Wrapper.m_SpectateMapActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_SpectateMapActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_SpectateMapActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_SpectateMapActionsCallbackInterface.OnSelect;
                @Additive.started -= m_Wrapper.m_SpectateMapActionsCallbackInterface.OnAdditive;
                @Additive.performed -= m_Wrapper.m_SpectateMapActionsCallbackInterface.OnAdditive;
                @Additive.canceled -= m_Wrapper.m_SpectateMapActionsCallbackInterface.OnAdditive;
                @Subtract.started -= m_Wrapper.m_SpectateMapActionsCallbackInterface.OnSubtract;
                @Subtract.performed -= m_Wrapper.m_SpectateMapActionsCallbackInterface.OnSubtract;
                @Subtract.canceled -= m_Wrapper.m_SpectateMapActionsCallbackInterface.OnSubtract;
            }
            m_Wrapper.m_SpectateMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Additive.started += instance.OnAdditive;
                @Additive.performed += instance.OnAdditive;
                @Additive.canceled += instance.OnAdditive;
                @Subtract.started += instance.OnSubtract;
                @Subtract.performed += instance.OnSubtract;
                @Subtract.canceled += instance.OnSubtract;
            }
        }
    }
    public SpectateMapActions @SpectateMap => new SpectateMapActions(this);

    // UnitControlMap
    private readonly InputActionMap m_UnitControlMap;
    private IUnitControlMapActions m_UnitControlMapActionsCallbackInterface;
    private readonly InputAction m_UnitControlMap_Attack;
    private readonly InputAction m_UnitControlMap_Move;
    public struct UnitControlMapActions
    {
        private @InputLayout m_Wrapper;
        public UnitControlMapActions(@InputLayout wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attack => m_Wrapper.m_UnitControlMap_Attack;
        public InputAction @Move => m_Wrapper.m_UnitControlMap_Move;
        public InputActionMap Get() { return m_Wrapper.m_UnitControlMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UnitControlMapActions set) { return set.Get(); }
        public void SetCallbacks(IUnitControlMapActions instance)
        {
            if (m_Wrapper.m_UnitControlMapActionsCallbackInterface != null)
            {
                @Attack.started -= m_Wrapper.m_UnitControlMapActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_UnitControlMapActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_UnitControlMapActionsCallbackInterface.OnAttack;
                @Move.started -= m_Wrapper.m_UnitControlMapActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_UnitControlMapActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_UnitControlMapActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_UnitControlMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public UnitControlMapActions @UnitControlMap => new UnitControlMapActions(this);
    private int m_MouseandKeyboardSchemeIndex = -1;
    public InputControlScheme MouseandKeyboardScheme
    {
        get
        {
            if (m_MouseandKeyboardSchemeIndex == -1) m_MouseandKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse and Keyboard");
            return asset.controlSchemes[m_MouseandKeyboardSchemeIndex];
        }
    }
    public interface ISpectateMapActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnAdditive(InputAction.CallbackContext context);
        void OnSubtract(InputAction.CallbackContext context);
    }
    public interface IUnitControlMapActions
    {
        void OnAttack(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
