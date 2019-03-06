using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private KeyCode _spawnKey;          // Keybind spawning objects
    [SerializeField]
    private GameObject _prefab;         // Prefab to spawn
    [SerializeField]
    private float _spawnCooldown;       // How fast prefabs spawn

    private void Start()
    {
        InvokeRepeating("SpawnPrefab", 0f, _spawnCooldown);
    }

    private void Update()
    {
        // Check for spawn input
        if(Input.GetKey(_spawnKey))
        {
            SpawnPrefab();
        }
    }

    // Spawn the prefab at the same position and rotation as this GameObject
    private void SpawnPrefab()
    {
        // Instantiate the prefab
        Instantiate(_prefab, transform.position, transform.rotation);
    }
}
