using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIController : Unit
{
    [SerializeField]
    private float _ShootCooldown = 1f;

    [SerializeField]
    private float _EnemyDetectionRadius = 5f;

    [SerializeField]
    private LayerMask _UnitsLayerMask;

    private NavMeshAgent _Agent;
    private IEnumerator _CurrentState;
    private Outpost _TargetOutpost;
    private Unit _TargetEnemy;

    public override void UnitAwake()
    {
        _Agent = GetComponent<NavMeshAgent>();
        GetComponent<Rigidbody>().isKinematic = true;
    }

    private new void Start()
    {
        base.Start();
        SetState(State_Idle());
    }

    private void Update()
    {
        _Anim.SetFloat("Vertical", _Agent.velocity.magnitude);
    }

    private void SetState(IEnumerator newState)
    {
        if(_CurrentState != null)
        {
            StopCoroutine(_CurrentState);
        }

        _CurrentState = newState;
        StartCoroutine(_CurrentState);
    }

    private IEnumerator State_Idle()
    {
        while(_TargetOutpost == null)
        {
            _TargetOutpost = Outpost.OutpostList.GetRandomItem();
            yield return null;
        }

        SetState(State_MovingToOutpost());
    }

    private IEnumerator State_MovingToOutpost()
    {
        _Agent.SetDestination(_TargetOutpost.transform.position);
        while(_Agent.remainingDistance > _Agent.stoppingDistance)
        {
            LookForEnemy();
            yield return null;
        }

        SetState(State_CapturingOutpost());
    }

    private IEnumerator State_CapturingOutpost()
    {
        while(_TargetOutpost != null && (_TargetOutpost.CurrentTeam != TeamNumber || _TargetOutpost.CaptureValue < 1f))
        {
            LookForEnemy();
            yield return null;
        }

        _TargetOutpost = null;
        SetState(State_Idle());
    }

    private IEnumerator State_AttackingEnemy()
    {
        _Agent.isStopped = true;
        _Agent.ResetPath();
        float shootTimer = 0f;

        while(_TargetEnemy != null && _TargetEnemy.IsAlive)
        {
            shootTimer += Time.deltaTime;

            transform.LookAt(_TargetEnemy.transform);

            //Euler is pronounced OILER
            transform.eulerAngles = new Vector3(0f, transform.eulerAngles.y, 0f);

            if(shootTimer >= _ShootCooldown)
            {
                shootTimer = 0f;
                ShootLasersFromEyes(_TargetEnemy.transform.position + Vector3.up, _TargetEnemy.transform);
            }

            yield return null;
        }

        _TargetEnemy = null;
        SetState(State_Idle());
    }

    private IEnumerator State_Dead()
    {
        yield return null;
    }


    private void LookForEnemy()
    {
        var aroundMe = Physics.OverlapSphere(transform.position, _EnemyDetectionRadius, _UnitsLayerMask);
        foreach (var item in aroundMe)
        {
            var otherUnit = item.GetComponent<Unit>();
            if(otherUnit != null && otherUnit.TeamNumber != TeamNumber && otherUnit.IsAlive)
            {
                _TargetEnemy = otherUnit;
                SetState(State_AttackingEnemy());
                return;
            }
        }
    }

    override protected void Die()
    {
        base.Die();
        _Agent.isStopped = true;
        _Agent.ResetPath();
        _TargetOutpost = null;
        SetState(State_Dead());
    }

}
