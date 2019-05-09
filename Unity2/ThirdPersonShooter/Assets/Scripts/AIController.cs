using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIController : Unit
{
    private NavMeshAgent _agent;
    private IEnumerator _currentState;
    private Outpost _targetOutpost;

    private NavMeshObstacle _obstacle;

    public override void UnitAwake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _rigidbody.isKinematic = true;
    }

    private void Start()
    {
        SetState(State_Idle());
    }

    private void SetState(IEnumerator newState)
    {
        if(_currentState != null)
        {
            StopCoroutine(_currentState);
        }

        _currentState = newState;
        StartCoroutine(_currentState);
    }

    private IEnumerator State_Idle()
    {
        while(_targetOutpost == null)
        {
            _targetOutpost = Outpost.OutpostList.GetRandomItem();
            yield return null;
        }

        SetState(State_MovingToOutPost());
    }

    private IEnumerator State_MovingToOutPost()
    {
        _agent.SetDestination(_targetOutpost.transform.position);

        while(_agent.remainingDistance > _agent.stoppingDistance)
        {
            yield return null;
        }

        _targetOutpost = null;
        SetState(State_Idle());
    }

    // private IEnumerator State_()
    // {
    //     // State Enter

    //     while(_targetOutpost == null)
    //     {
    //         yield return null;
    //     }

    //     // State exit (NOT ALWAYS)
    // }
}
