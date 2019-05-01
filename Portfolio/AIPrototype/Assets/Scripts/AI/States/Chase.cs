using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : IState
{
    private LayerMask _layer;               // Target layer

    private string _tag;                    // Target tag

    private float _radius;                  // Search radius

    private GameObject _gameObject;         // Owner GameObject

    private NavMeshAgent _navMeshAgent;     // Owner NavMeshAgent

    // Constructor
    public Chase(LayerMask layer, GameObject gameObject, float radius, NavMeshAgent navMeshAgent, string tag)
    {
#if UNITY_EDITOR
        Debug.Log("[Chase] Constructor");
#endif
        _layer = layer;
        _gameObject = gameObject;
        _radius = radius;
        _navMeshAgent = navMeshAgent;
        _tag = tag;
    }

    public void Enter()
    {
#if UNITY_EDITOR
        Debug.Log("[Chase] Start State");
#endif
    }

    public void Execute()
    {
#if UNITY_EDITOR
        Debug.Log("[Chase] Execute State");
#endif
        // Collision check
        var targetObjects = Physics.OverlapSphere(_gameObject.transform.position, _radius);
        for (int i = 0; i < targetObjects.Length; i++)
        {
            // Compare tag
            if (targetObjects[i].CompareTag(_tag))
            {
                float targetPosX = targetObjects[i].transform.position.x;
                float targetPosY = targetObjects[i].transform.position.y;
                float targetPosZ = targetObjects[i].transform.position.z;
                Vector3 targetPosition = new Vector3(targetPosX, targetPosY, targetPosZ);
                // Set destination
                _navMeshAgent.SetDestination(targetPosition);
                break;
            }
        }
    }

    public void Exit()
    {
#if UNITY_EDITOR
        Debug.Log("[Chase] Exit State");
#endif
    }
}
