using UnityEngine;

public class Building : InteractiveObject
{
    [SerializeField] private Material nativeMaterial;
    [SerializeField] private Material hightLight;
    

    public override void Select()
    {
        GetComponent<MeshRenderer>().material = hightLight;
    }

    public override void Deselect()
    {
        GetComponent<MeshRenderer>().material = nativeMaterial;
    }
}
