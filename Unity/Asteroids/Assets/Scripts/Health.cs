using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int _currentHealth = 1;                // current/initial health
    [SerializeField] private int _scoreValue = 0;                   // score awarded on death
    [SerializeField] private ParticleSystem _deathParticles;
    [SerializeField] private float _deathParticlesDuration = 1f;
    private int _maxHealth;                                         // max health

    // make current health percentage visible
    public float HealthPercentage => (float)_currentHealth / _maxHealth;

    // on death unity event
    [SerializeField] private UnityEvent OnDeath;

    private void Start()
    {
        _maxHealth = _currentHealth;
    }

    // deal damage to Health
    public void Damage(int amount)
    {
        // deal damage
        _currentHealth -= amount;

        // check if still alive
        if(_currentHealth <= 0)
        {
            Death();
        }
    }

    // called on Death
    private void Death()
    {
        // spawn death particles
        if(_deathParticles != null)
        {
            // this will instantiate and destroy our particles simultaneously
            Destroy(Instantiate(_deathParticles, transform.position, transform.rotation), _deathParticlesDuration);
        }

        // add score on death
        Score.Instance.AddScore(_scoreValue);

        // call OnDeath event
        OnDeath?.Invoke();

        // destroy the gameobject
        Destroy(gameObject);
    }
}
