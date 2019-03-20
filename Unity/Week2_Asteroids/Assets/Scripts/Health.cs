using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int _currentHealth = 1;                     // Current/Initial health
    private int _maxHealth;                             // Max Health

    [SerializeField]
    private ParticleSystem _deathParticles;

    [SerializeField]
    private float _deathParticlesDuration = 1.0f;

    // Make current health percentage visible
    public float HealthPercentage => (float)_currentHealth / _maxHealth;

    private void Start()
    {
        _maxHealth = _currentHealth;
    }

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
        // Spawn death particles
        if(_deathParticles != null)
        {
            // This will instantiate and destroy particles simultaneously
            Destroy(Instantiate(_deathParticles, transform.position, transform.rotation), _deathParticlesDuration);
        }

        // Destroy the gameobject
        Destroy(gameObject);
    }
}
