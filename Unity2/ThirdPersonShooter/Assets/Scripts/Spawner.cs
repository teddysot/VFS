using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _spawnObject;
    [SerializeField] private float _spawnCooldown = 5.0f;

    private Outpost _outpost;
    private bool _canSpawn = true;

    private void Start()
    {
        _outpost = GetComponent<Outpost>();
    }

    private void Update()
    {
        if(_outpost.CurrentControlledTeam > 0 && _canSpawn)
        {
            StartCoroutine(SpawnCooldown());
            SpawnObject();
        }
    }

    IEnumerator SpawnCooldown()
    {
        _canSpawn = false;
        yield return new WaitForSeconds(_spawnCooldown);
        _canSpawn = true;
    }

    void SpawnObject()
    {
        var spawnPos = gameObject.transform.position + Vector3.forward;
        _spawnObject.GetComponent<AIController>().TeamNumber = _outpost.CurrentControlledTeam;
        Instantiate(_spawnObject, spawnPos, Quaternion.identity);
    }
}
