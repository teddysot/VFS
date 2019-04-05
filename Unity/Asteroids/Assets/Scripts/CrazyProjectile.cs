using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyProjectile : Projectile
{
    [SerializeField] private float _torque = 5f;        // rotation force added

    private void FixedUpdate()
    {
        // get an initial noise value
        float noise = Mathf.PerlinNoise(transform.position.x, transform.position.z);
        // remap noise from 0 to 1, to -1 to 1
        noise = noise * 2f - 1f;

        // find torque to be added
        Vector3 torque = Vector3.up * _torque * noise;

        // add torque and set velocity
        _rigidbody.AddTorque(torque);
        _rigidbody.velocity = transform.forward * _velocity;
    }
}