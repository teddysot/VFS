using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject _projectilePrefab;      // prefab we're firing
    [SerializeField] private float _cooldown = 0.25f;           // time between shots

    // For AOE Setting
    [Header("AOE Setting")]
    [SerializeField] private int _numElement = 12; // Number of element to shoot


    private float _lastFireTime;                                // the time when we fired last

    // try firing the weapon
    public void TryFire()
    {
        // check if weapon can fire based on cooldown
        if(Time.timeSinceLevelLoad >= _lastFireTime + _cooldown)
        {
            _lastFireTime = Time.timeSinceLevelLoad;
            Fire();
        }

    }

    public void TryAOEFire()
    {
        // check if weapon can fire based on cooldown
        if (Time.timeSinceLevelLoad >= _lastFireTime + _cooldown)
        {
            _lastFireTime = Time.timeSinceLevelLoad;
            AOEFire();
        }

    }

    // actually fire the weapon
    private void Fire()
    {
        // instantiate the projectile prefab
        Instantiate(_projectilePrefab, transform.position, transform.rotation);
    }

    // Instantiate AOE projectile
    private void AOEFire()
    {
        // Looping for rotate the projectile
        for (int i = 0; i < _numElement; i++)
        {
            // Turn to a degree's angles
            float angleIteration = 360 / _numElement;

            // Current rotation of the projectile after rotated
            float curRotation = angleIteration * i;

            // Spawn projectile
            Instantiate(_projectilePrefab, transform.position, transform.rotation);

            // Rotating projectile
            transform.Rotate(new Vector3(0, transform.parent.position.x + curRotation, 0));
            
            // Set offset of the spawn position
            //transform.Translate(new Vector3(transform.parent.position.x + 1.0f, 0, 0));
        }
    }
}