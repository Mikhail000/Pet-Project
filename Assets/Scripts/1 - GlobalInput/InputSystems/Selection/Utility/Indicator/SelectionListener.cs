using UnityEngine;

public abstract class SelectionListener<T> : MonoBehaviour where T : IEntity
{
    
    protected SelectionReceiver<T> receiver;

    protected virtual void Awake()
    {
        receiver = GetComponent<SelectionReceiver<T>>();
        if (receiver == null)
        {
            Debug.LogError("SelectionReceiver<T> component is not found on the object.", this);
        }
    }

    protected virtual void OnEnable()
    {
        if (receiver != null)
        {
            receiver.OnSelect += OnSelect;
            receiver.OnDeselect += OnDeselect;
            receiver.OnHoverEnter += OnHoverEnter;
            receiver.OnHoverExit += OnHoverExit;
            //Debug.Log("Subscribed to events.", this);
        }
        else
        {
            //Debug.LogError("Receiver is null on enable.", this);
        }
    }
        
    protected virtual void OnDisable()
    {
        receiver.OnSelect -= OnSelect;
        receiver.OnDeselect -= OnDeselect;
        receiver.OnHoverEnter -= OnHoverEnter;
        receiver.OnHoverExit -= OnHoverExit;
    }

    protected abstract void OnSelect();
    protected abstract void OnDeselect();
    protected abstract void OnHoverEnter();
    protected abstract void OnHoverExit();
}
