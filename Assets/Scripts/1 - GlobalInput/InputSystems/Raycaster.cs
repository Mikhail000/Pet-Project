using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public static Raycaster Instance { get; private set; }

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public RaycastHit? CastRay(Vector3 origin, Vector3 direction, float distance)
    {
        RaycastHit hit;
        if (Physics.Raycast(origin, direction, out hit, distance))
        {
            return hit;
        }

        return null;
    }
}