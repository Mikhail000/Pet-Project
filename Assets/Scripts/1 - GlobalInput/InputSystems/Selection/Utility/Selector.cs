using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;

namespace InputSystem
{
    public class Selector : MonoBehaviour, IReaderSubscriber<SelectionReader>, IDisposable
    {
        [field: SerializeField] public LayerMask UnitLayer { get; private set; } = default;
        [field: SerializeField] public LayerMask GroundLayer { get; private set; } = default;

        [SerializeField] private GameObject box = default;
        [SerializeField] private SelectionBox selectionBox = default;
        [SerializeField] public MeshCollider selectionCollider = default;
        [SerializeField] private float _clickRadius = 0f;
        [SerializeField] private Separator separator;


        private Vector2 _startPosition = default;
        private static Vector2 _endPosition => Input.mousePosition;

        private bool _dragSelection =>
            Vector2.Distance(_startPosition, _endPosition) > 1; // можно вынести в класс SelectionBox

        private static IInputProvider InputProvider => GameData.Instance.Input.Provider;
        private ISelectionReceiver _hoverSelection = default;
        private readonly List<ISelectionReceiver> Selection = SelectionList.selection;
        private Mesh _currentSelectionMesh = default;
        private GameObject _currentBox;

        private bool AdditiveModifier { get; set; } = default;
        private bool SubtractiveModifier { get; set; } = default;

        private void Start()
        {
            CreateSelectionArea();
        }

        public void SubscribeEvents(SelectionReader reader)
        {
            reader.SelectPressEvent += StartSelect;
            reader.SelectReleaseEvent += ReleaseSelect;

            reader.AdditivePressEvent += PressAdditional;
            reader.AdditiveReleaseEvent += ReleaseAdditional;

            reader.SubsractPressEvent += PressSubtract;
            reader.SubsractReleaseEvent += ReleaseSubtract;
        }

        private void Update()
        {
            ProcessInput();
        }

        private void StartSelect()
        {
            _startPosition = Input.mousePosition;
            selectionBox.enabled = true;
            Cursor.visible = false;
        }

        private void ReleaseSelect()
        {
            selectionBox.enabled = false;
            Cursor.visible = true;
            if (AdditiveModifier is false && SubtractiveModifier is false)
                ClearSelection();

            if (_dragSelection)
                StartCoroutine(BoxSelect());
            else
                ClickSelect().ForEach(ProcessSelectable);
        }

        private void PressAdditional() => AdditiveModifier = true;
        private void ReleaseAdditional() => AdditiveModifier = false;

        private void PressSubtract() => SubtractiveModifier = true;
        private void ReleaseSubtract() => SubtractiveModifier = false;

        private void ProcessInput()
        {
            if (GameCursor.CursorVisible)
                ProcessHover(ref _hoverSelection);
        }

        private void CreateSelectionArea()
        {
            if (UICanvas.Instance != null)
            {
                _currentBox = Instantiate(box, UICanvas.Instance.GetCanvasTransform());
                box.transform.localPosition = Vector3.zero;
                _currentBox.TryGetComponent(out SelectionBox b);
                selectionBox = b;
            }
        }

        private List<ISelectionReceiver> ClickSelect() =>
            ClickCast().Select(hit => hit.rigidbody.GetComponent<ISelectionReceiver>()).ToList();

        private IEnumerable<RaycastHit> ClickCast()
        {
            var cam = Camera.main;
            var ray = cam.ScreenPointToRay(Input.mousePosition);
            var distance = cam.farClipPlane;
            var start = ray.origin;
            var end = ray.origin + ray.direction * distance;
            Debug.DrawRay(ray.origin, ray.direction * distance, Color.yellow, 3f);
            return _clickRadius > 0 // Если мы не растянули прямоугольник, то...
                ? Physics.CapsuleCastAll(start, end, _clickRadius, ray.direction,
                    Mathf.Infinity, // просто кастании луч и выберем 1н объект
                    UnitLayer).Where(hit => hit.rigidbody != null)
                : Physics.RaycastAll(start, end, Mathf.Infinity, UnitLayer) // кастани  
                    .Where(hit => hit.rigidbody != null);
        }

        private IEnumerator BoxSelect()
        {
            selectionCollider.sharedMesh = MeshBuilder.BoxSelect(_startPosition, _endPosition);
            yield return new WaitForFixedUpdate();
            Dispose();
        }

        private void OnTriggerEnter(Collider col)
        {
            //if (col.gameObject.layer != SelectorData.Instance.Settings.UnitLayer) return;
            if (col.attachedRigidbody == null) return;
            if (col.attachedRigidbody.TryGetComponent<ISelectionReceiver>(out var selectable))
                ProcessSelectable(selectable);
            
        }

        private void ProcessSelectable(ISelectionReceiver selectable)
        {
            if (selectable is null) return;

            if (SubtractiveModifier) 
                Deselect(); 
            else
                Select(); 

            void Select() 
            {
                if (Selection.Contains(selectable)) return;
                //selectable.Select();
                Selection.Add(selectable);
                separator.ProcessSelectedObjects(selectable);
            }

            void Deselect()
            {
                if (Selection.Contains(selectable) is false) return;
                selectable.Deselect();
                Selection.Remove(selectable);
            }
        }

        private static void ProcessHover(ref ISelectionReceiver current)
        {
            if (GameCursor.TryGetSelectable(out var newSelection))
            {
                if (current == newSelection) return;
                current?.HoverExit();
                newSelection.HoverEnter();
                current = newSelection;
            }
            else
            {
                current?.HoverExit();
                current = null;
            }
        }

        private void ClearSelection()
        {
            Selection.ForEach(selectable => selectable.Deselect());
            Selection.Clear();
        }

        public void Dispose()
        {
            if (selectionCollider.sharedMesh is null) return;
            selectionCollider.sharedMesh = null;
            Destroy(_currentSelectionMesh);
        }

        private void OnDestroy() => Dispose();
    }
}