using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;         // movement acceleration of the ship
    [SerializeField] private float _turnSpeed = 10f;        // turn acceleration of the ship
    
    private Rigidbody _rigidbody;
    private Weapon[] _weapons;
    private Vector2 _input;
    [SerializeField] private int _currentWeaponIndex;

    // awake is similar to Start, but executes before Start
    private void Awake()
    {
        // get the attached rigidbody component
        _rigidbody = GetComponent<Rigidbody>();

        // get the attached weapon
        _weapons = GetComponentsInChildren<Weapon>();
    }

    private void Update()
    {
        // get player inputs
        _input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // change weapons
        if(Input.GetButtonDown("ChangeWeapon"))
        {
            _currentWeaponIndex++;
        }

        // try firing the weapon
        if(Input.GetButton("Fire1") && _currentWeaponIndex % _weapons.Length != 2) // If single projectile weapon
        {
            _weapons[_currentWeaponIndex % _weapons.Length].TryFire();
        }
        else if (Input.GetButton("Fire1") && _currentWeaponIndex % _weapons.Length == 2) // If weapon is an AOE
        {
            _weapons[_currentWeaponIndex % _weapons.Length].TryAOEFire();
        }
    }

    private void FixedUpdate()
    {
        // move the ship forwards/backwards
        _rigidbody.AddForce(transform.forward * _input.y * _moveSpeed);

        // turn the ship
        _rigidbody.AddTorque(transform.up * _input.x * _turnSpeed);
    }
}
