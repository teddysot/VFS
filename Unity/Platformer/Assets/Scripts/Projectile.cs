using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]

public class Projectile : MonoBehaviour
{
    // Initial velocity
    [SerializeField] private float _velocity = 10.0f;

    // Damage dealt
    [SerializeField] private int _damage = 1;

    // Physics components
    private Rigidbody2D _rigidbody;
    private Collider2D _collider;
    private Vector2 _currentVelocity;

    // Called once gameobject is create, before start
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();

    }

    public void Initialize(Collider2D owner)
    {
        // Disable collision with shooter
        Physics2D.IgnoreCollision(_collider, owner);

        // Shoot projectile
        _rigidbody.velocity = transform.up * _velocity;
    }

    private void FixedUpdate()
    {
        // Check for minimum velocity
        if(_rigidbody.velocity.magnitude >= 0.05f)
        {
            // Rotate in the direction of our velocity
            transform.rotation = Quaternion.LookRotation(Vector3.forward, _rigidbody.velocity);
        }

        // Record current velocity
        _currentVelocity = _rigidbody.velocity;
    }

    // Exactly like OnCollisionEnter, but in 2D
    private void OnCollisionEnter2D(Collision2D other)
    {
        // Stick to whatever we hit
        transform.SetParent(other.transform);

        // Stop all movement
        _rigidbody.bodyType = RigidbodyType2D.Kinematic;
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.angularVelocity = 0.0f;

        // Stop collision
        _collider.isTrigger = true;

        // Rotate in the direction of our velocity
        transform.rotation = Quaternion.LookRotation(Vector3.forward, _currentVelocity);

        // Damage anything we hit
        other.gameObject.GetComponent<Health>()?.Damage(_damage);
    }
}
