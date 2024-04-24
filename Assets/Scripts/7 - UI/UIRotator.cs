using System;
using UnityEngine;

public class UIRotator : MonoBehaviour
{
   private static Camera Camera => GameData.Instance.Input.Provider.Camera;
   private Transform _cameraTransform;

   private void Start()
   {
      _cameraTransform = Camera.transform;
   }

   private void FixedUpdate()
   {
      Vector3 v = Camera.transform.position - transform.position;
      
      transform.LookAt(_cameraTransform);
   }
}
