using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIUnit : MonoBehaviour
{
    [SerializeField] private RefTransform _playerTransform;

    [SerializeField] private RefFloat _playerHealth;

    private NavMeshAgent _agent;

    private void Awake() 
    {
        _agent = GetComponent<NavMeshAgent>();
    
    }

    private void OnEnable() 
    {
        _playerHealth.OnValueChanged += ((h) =>
        {
            print(h);
        });
    }

    private void Update()
    {
        if(_playerTransform == null || _playerTransform.Value == null)
        {
            return;
        }

        _agent.SetDestination(_playerTransform.Value.position);
    }
}
