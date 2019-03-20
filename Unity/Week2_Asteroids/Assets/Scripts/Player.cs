using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 5.0f;        // Movement acceleration of the ship
    [SerializeField]
    private float _turnSpeed = 10.0f;       // Turn acceleration of the ship

    private Rigidbody _rigidbody;
    private Weapon[] _weapons;
    private Vector2 _input;
    private int _currentWeaponIndex;

    private void Awake()
    {
        // Get the attached rigidbody component
        _rigidbody = GetComponent<Rigidbody>();

        // Get the attached weapon
        _weapons = GetComponentsInChildren<Weapon>();
    }

    private void Update()
    {
        // Get player inputs
        _input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // Change weapons
        if (Input.GetButtonDown("ChangeWeapon"))
        {
            _currentWeaponIndex++;
            if (_currentWeaponIndex >= _weapons.Length)
            {
                _currentWeaponIndex = 0;
            }
        }

        // Try firing the weapon
        if (Input.GetButton("Fire1"))
        {
            _weapons[_currentWeaponIndex].TryFire();
        }
    }

    private void FixedUpdate()
    {
        // Move the ship forwards/backwards
        _rigidbody.AddForce(transform.forward * _input.y * _moveSpeed);

        // Turn the ship
        _rigidbody.AddTorque(Vector3.up * _input.x * _turnSpeed);
    }
}
