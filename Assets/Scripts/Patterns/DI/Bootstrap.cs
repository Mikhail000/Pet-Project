using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private GameObject GUI;
    [SerializeField] private GameObject world;
    [SerializeField] private GameObject InputHandler;
    
    private void Awake()
    {
        Instantiate(GUI);
        Instantiate(InputHandler);
        Instantiate(world);
    }
}
