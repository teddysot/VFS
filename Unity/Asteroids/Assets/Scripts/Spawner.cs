using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _spawnCooldown = 3f;         // cooldown between spawns
    [SerializeField] private GameObject _prefab;                // prefab to spawn
    [SerializeField] private float _inaccuracy = 30f;           // inaccuracy when spawning asteroid

    private void Start()
    {
        InvokeRepeating("SpawnAsteroid", Random.value * _spawnCooldown, _spawnCooldown);
    }

    private void SpawnAsteroid()
    {
        Vector3 spawnPosition = transform.position;

        // generate random spawn rotation
        float randomAngle = Random.Range(-_inaccuracy, _inaccuracy);
        Quaternion randomRotation = Quaternion.Euler(0f, randomAngle, 0f);
        Quaternion spawnRotation = transform.rotation * randomRotation;

        Instantiate(_prefab, spawnPosition, spawnRotation);
    }
}
