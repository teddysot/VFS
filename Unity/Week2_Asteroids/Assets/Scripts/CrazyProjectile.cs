using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyProjectile : Projectile
{
    [SerializeField]
    private float _torque = 5.0f;       // Rotation force added

    private void FixedUpdate()
    {
        // Get an initial noise value
        float noise = Mathf.PerlinNoise(transform.position.x, transform.position.z);

        // Remap noise from 0 to 1, into -1 to 1
        noise = noise * 2.0f - 1.0f;

        // Find torque to be added
        Vector3 torque = Vector3.up * _torque * noise;

        // Add torque and set velocity
        _rigidbody.AddTorque(torque);
        _rigidbody.velocity = transform.forward * _velocity;
    }
}
