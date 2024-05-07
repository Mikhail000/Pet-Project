using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    private float _currentHealth;

    private void Start()
    {
        _currentHealth = maxHealth;
    }

    public void Substract(float value)
    {
        if (value < 0)
            return;
        
        if (_currentHealth < 0)
            _currentHealth = 0;
        
    }

    public void Add(float value)
    {
        if (_currentHealth >= maxHealth)
            return;
        
        _currentHealth += value;
    }
}
