using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private GameObject _projectilePrefab;       // Prefab we are firing
    [SerializeField]
    private float _cooldown = 0.25f;            // Time between shots

    private float _lastFireTime;                // The time when we fired last

    // Try firing the weapon
    public void TryFire()
    {
        Fire();
    }

    // Actually fire the weapon
    private void Fire()
    {
        // Instantiate the projectile prefab
        Instantiate(_projectilePrefab, transform.position, transform.rotation);
    }
}
