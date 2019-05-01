using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class MeleeEnemy : MonoBehaviour
{
    private StateMachine _stateMachine = new StateMachine();    // Initialize StateMachine
    private NavMeshAgent _navMeshAgent;                         // NavMeshAgent

    [SerializeField] private LayerMask _targetLayer;            // Target layer
    [SerializeField] private string _targetTag;                 // Target tag
    [SerializeField] private float _viewRange;                  // View range


    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _stateMachine.ChangeState(new Chase(_targetLayer, gameObject, _viewRange, _navMeshAgent, _targetTag));
    }

    // Update is called once per frame
    void Update()
    {
        _stateMachine.ExecuteState();
    }
}
