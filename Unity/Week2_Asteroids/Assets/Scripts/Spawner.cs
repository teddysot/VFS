using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float _spawnCooldown = 3.0f;        // Cooldown between spawns
    [SerializeField]
    private GameObject _prefab;                 // Prefab to spawn
    [SerializeField]
    private float _inaccuracy = 30.0f;          // Inaccuracy when spawning prefab

    private void Start()
    {
        InvokeRepeating("SpawnAsteroid", Random.value * _spawnCooldown, _spawnCooldown);
    }

    private void SpawnAsteroid()
    {
        Vector3 spawnPosition = transform.position;

        // Generate random spawn rotation
        float randomAngle = Random.Range(-_inaccuracy, _inaccuracy);
        Quaternion randomRotation = Quaternion.Euler(0.0f, randomAngle, 0.0f);
        Quaternion spawnRotation = transform.rotation * randomRotation;

        Instantiate(_prefab, spawnPosition, spawnRotation);
    }
}
