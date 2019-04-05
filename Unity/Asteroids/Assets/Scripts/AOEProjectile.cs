using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOEProjectile : Projectile
{
    private void FixedUpdate()
    {
        // Add forward velocity
       _rigidbody.velocity = transform.forward * _velocity;
    }
}