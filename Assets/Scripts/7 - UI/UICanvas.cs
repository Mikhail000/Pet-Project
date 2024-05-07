using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICanvas : MonoBehaviour
{
    public static UICanvas Instance { get; private set; }

    private Transform _canvasTransform;
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            _canvasTransform = transform;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Transform GetCanvasTransform()
    {
        return _canvasTransform;
    }
}
