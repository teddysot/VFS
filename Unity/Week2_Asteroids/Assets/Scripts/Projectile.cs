using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float _velocity = 10.0f;        // Initial velocity
    [SerializeField]
    private float _lifeTime = 5.0f;        // Total life time

    private Rigidbody _rigidbody;   // Rigidbody of the object

    private void Awake()
    {
        // Get the rigidbody
        _rigidbody = GetComponent<Rigidbody>();

        // Launch the projectile
        _rigidbody.velocity = transform.forward * _velocity;

        // Destroy the gameobject after lifetime seconds
        Destroy(gameObject, _lifeTime);
    }
}
