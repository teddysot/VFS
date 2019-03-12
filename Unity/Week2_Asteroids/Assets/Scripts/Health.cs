using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int _currentHealth = 1;     // Current/Initial health

    public void Damage(int amount)
    {
        // Deal damage
        _currentHealth -= amount;

        // Check if still alive
        if(_currentHealth <= 0)
        {
            Death();
        }
    }

    // Called on Death
    private void Death()
    {
        // Destroy the gameobject
        Destroy(gameObject);
    }
}
