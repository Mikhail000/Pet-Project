using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

[Serializable]
public class ActionCommandPair
{
    public InputAction key;
    public BaseCommand val;
}

public class InputHandler : MonoBehaviour
{
    [SerializeField] private IInputService selector;
    private List<ActionCommandPair> _actionCommandList = new List<ActionCommandPair>();
    public Dictionary<InputAction, BaseCommand> bindActions = new Dictionary<InputAction, BaseCommand>();
    public Dictionary<BaseCommand, InputAction> reversedBindActions = new Dictionary<BaseCommand, InputAction>();

    [SerializeField] private IInputService _service;
    
    #region Singleton

    public static InputHandler Instance;

   private void Awake()
   {
       if (Instance == null)
       {
           Instance = this;
           DontDestroyOnLoad(this);
       }
       else
       {
           Destroy(this.gameObject);
       }
   }

    #endregion Singleton
    

    private void Update()
    {
        foreach (var action in bindActions)
        {
            action.Value.Execute(action.Key, selector);
        }
    }

    private void OnEnable()
    {
        UpdateActionsCommandsBindings();
    }

    private void OnDisable()
    {
        foreach (var action in bindActions) 
            action.Key.Disable();
    }

    public void UpdateActionsCommandsBindings()
    {
        bindActions.Clear();
        reversedBindActions.Clear();
        foreach (var acp in _actionCommandList)
        {
            bindActions[acp.key] = acp.val;
            reversedBindActions[acp.val] = acp.key;
            acp.key.Enable();
        }
    }

    public void UpdateActionsCommandsList(List<ActionCommandPair> aList, IInputService s)
    {
        _actionCommandList = aList;
        _service = s;
    }
}
