using UnityEngine;

public class SelectionColor : SelectionListener<IUnit>
{
    //protected override SelectionReceiver<IEntity> Receiver { get; set; } = new SelectionReceiver<IUnit>();
    [SerializeField] private MeshRenderer _meshRenderer = default;
    [SerializeField] private ColorSettings _colorSettings = default;
    private Material _defaultMaterial = default;
    private Material _selectionMaterial = default;
    private Material _hoverMaterial = default;

    private void Start()
    {
        
        _defaultMaterial = _meshRenderer.sharedMaterial;
        _selectionMaterial = new Material(_meshRenderer.material) { color = _colorSettings.SelectionColor };
        _selectionMaterial.shader = Shader.Find("Universal Render Pipeline/Unlit");
        _hoverMaterial = new Material(_meshRenderer.material) { color = _colorSettings.HoverColor };
        _hoverMaterial.shader = Shader.Find("Universal Render Pipeline/Unlit");
    }
    
    protected override void OnSelect() => _meshRenderer.material = _selectionMaterial;
    protected override void OnDeselect() => _meshRenderer.material = receiver.Hovering ? _hoverMaterial : _defaultMaterial;
    protected override void OnHoverEnter() => _meshRenderer.material = receiver.Selected ? _selectionMaterial : _hoverMaterial;
    protected override void OnHoverExit() => _meshRenderer.material = receiver.Selected ? _selectionMaterial : _defaultMaterial;
}
