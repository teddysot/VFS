using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
    [SerializeField]
    private int _damage = 1;        // Damage dealth on collision

    // Called when the gameObject collides with another gameObject
    private void OnCollisionEnter(Collision other)
    {
        // (Method 1) Check if the other gameObject has a health component and then damage it
        Health otherHealth = other.gameObject.GetComponent<Health>();
        if(otherHealth != null)
        {
            otherHealth.Damage(_damage);
        }

        ////  (Method 2) Check if the other gameObject has a health component and then damage it
        //other.gameObject.GetComponent<Health>()?.Damage(_damage);
    }
}
