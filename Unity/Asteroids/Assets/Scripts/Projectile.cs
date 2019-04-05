using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] protected float _velocity = 10f;      // the initial velocity
    [SerializeField] private float _lifeTime = 5f;       // the total life time

    protected Rigidbody _rigidbody;

    private void Awake()
    {
        // get the rigidbody
        _rigidbody = GetComponent<Rigidbody>();

        // launch the projectile
        _rigidbody.velocity = transform.forward * _velocity;

        // destroy the gameobject after lifeTime seconds
        Destroy(gameObject, _lifeTime);
    }
}
