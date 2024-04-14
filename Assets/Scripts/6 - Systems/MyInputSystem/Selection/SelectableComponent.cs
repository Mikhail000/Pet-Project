using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableComponent : MonoBehaviour
{
   [SerializeField] private GameObject selectionIndicator;

   private void Awake()
   {
     SelectionManager.Instance.AvailableUnits.Add(this); 
   }

   public void OnSelect()
   {
      selectionIndicator.SetActive(true);
      Debug.Log("Privet");
   }

   public void OnDeselect()
   {
      selectionIndicator.SetActive(false);
   }
}
