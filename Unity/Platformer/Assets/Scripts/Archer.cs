using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : CharacterController2D
{
    // Player input settings
    [Header("Input")]
    [SerializeField] private string _moveInput = "Horizontal";
    [SerializeField] private string _jumpInput = "Jump";
    [SerializeField] private string _shootInput = "Fire1";

    // Shooting settings
    [Header("Shooting")]
    [SerializeField] private Projectile _projectilePrefab;
    [SerializeField] private Vector2 _spawnOffset = new Vector2(0.2f, 0.5f);

    // Is Archer dead?
    private bool _isDead = false;

    protected override void Update()
    {
        // Do nothing if archer is dead
        if(_isDead)
        {
            return;
        }

        // Call the base Update
        base.Update();

        // Movement
        float movement = Input.GetAxis(_moveInput);

        SetMoveInput(movement);

        // Jump
        if(Input.GetButtonDown(_jumpInput))
        {
            TryJump();
        }

        // Shoot
        if(Input.GetButtonDown(_shootInput))
        {
            TryShoot();
        }
    }

    private void TryShoot()
    {
        // Which direction are we facing?
        bool facingLeft = SpriteRenderer.flipX;

        // Find spawn position
        Vector3 spawnOffset = facingLeft ? new Vector3(-_spawnOffset.x, _spawnOffset.y)
                                         : new Vector3(_spawnOffset.x, _spawnOffset.y);
        Vector3 spawnPosition = transform.position + spawnOffset;

        // Find spawn rotation
        Quaternion spawnRotation = facingLeft ? Quaternion.LookRotation(Vector3.forward, Vector3.left)
                                              : Quaternion.LookRotation(Vector3.forward, Vector3.right);

        // Instantiate Projectile
        Projectile arrow = Instantiate(_projectilePrefab, spawnPosition, spawnRotation);
        arrow.Initialize(Collider);

        // Play Shoot Animation
        Animator.SetTrigger("Shoot");
    }

    // Initiate death
    public void Death()
    {
        if(_isDead)
        {
            return;
        }

        // Start the DeathRoutine couroutine
        StartCoroutine(DeathRoutine());
    }

    // Death sequence Coroutine
    private IEnumerator DeathRoutine()
    {
        // Set dead to true
        _isDead = true;

        // Play Death animation
        Animator.SetTrigger("Death");

        // Wait for 2 seconds
        //yield return new WaitForSeconds(2.0f);

        float timer = 2.0f;
        while(timer > 0.0f)
        {
            // Called every frame
            timer -= Time.deltaTime;

            Debug.Log("I'm Dying!");

            yield return new WaitForEndOfFrame();
        }

        // Destroy gameObject
        Destroy(gameObject);
    }
}
