using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class BarrackMenu : SelectionListener<IBuilding>
{
    [SerializeField] private PoolData selectionPool = default;
    
    private GameObject _selection = default;
    protected override void OnSelect()
    {
        if (_selection != null) return;
        //if (_hover) Unload(_hoverPool, ref _hover);
        _selection = Load(selectionPool);
    }

    protected override void OnDeselect()
    {
        if (_selection == null) return;
        Unload(selectionPool, ref _selection);
    }

    private GameObject Load(PoolData pool)
    {
        var instance = pool.Pool.Get();
        instance.transform.SetParent(transform);
        instance.transform.localPosition = new UnityEngine.Vector3(0, 2,0);
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
        // потом переопределю
    }

    protected override void OnHoverExit()
    {
        // ниче не делаем
    }
}
