using System;
using UnityEngine;

public class CameraFacing : MonoBehaviour
{
   public Transform CameraAnchor;
   private Transform _localTransform;

   private void Start()
   {
      _localTransform = GetComponent<Transform>();
   }

   private void FixedUpdate()
   {
      if (CameraAnchor)
      {
         _localTransform.LookAt(2 * _localTransform.position - CameraAnchor.position);
      }
   }
}
