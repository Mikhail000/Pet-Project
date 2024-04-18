using System;
using Controls;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] private ActionsCommandsScheme menuScheme;

    private void Start()
    {
        ActivateMenuScheme();
    }

    public void ActivateMenuScheme()
    {
        InputHandler.Instance.UpdateActionsCommandsList(menuScheme.actionCommandList);
        InputHandler.Instance.UpdateActionsCommandsBindings();
    }
}
