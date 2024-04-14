using System;
using UnityEngine;

// Родительский класс Unit // Служит началом для всех живых юнитов.
public abstract class Unit : MonoBehaviour
{
   [SerializeField] protected PlayableUnitData Data;
   
   [HideInInspector] protected double Health;
   [HideInInspector] protected double HitPower;
   [HideInInspector] protected double Velocity;
   [HideInInspector] protected AttackTypesIDs AttackType;
   
   private double _currentHealth;

   protected virtual void Start()
   {
      InitializeData(Data);
   }

   private void InitializeData(PlayableUnitData data)
   {
      Health = data.Health;
      HitPower = data.HitPower;
      Velocity = data.Velocity;
      AttackType = data.AttackType;
   }
}

