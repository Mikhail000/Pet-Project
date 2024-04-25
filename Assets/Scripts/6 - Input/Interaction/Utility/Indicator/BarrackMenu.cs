using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrackMenu : SelectionListener
{
    [SerializeField] private PoolData _selectionPool = default;
    
    private GameObject _selection = default;
    
    protected override void OnSelect()
    {
        if (_selection != null) return;
        //if (_hover) Unload(_hoverPool, ref _hover);
        _selection = Load(_selectionPool);
    }

    protected override void OnDeselect()
    {
        if (_selection == null) return;
        Unload(_selectionPool, ref _selection);
    }

    private GameObject Load(PoolData pool)
    {
        var instance = pool.Pool.Get();
        instance.transform.SetParent(transform);
        instance.transform.localPosition = default;
        instance.transform.localScale = Vector3.one;
        instance.gameObject.SetActive(true);
        return instance;
    }

    private static void Unload(PoolData pool, ref GameObject instance)
    {
        if(instance == null) return;
        pool.Pool.Release(instance);
        instance = null;
    }
    
    protected override void OnHoverEnter()
    {
        // ниче не делаем
    }

    protected override void OnHoverExit()
    {
        // ниче не делаем
    }
}
