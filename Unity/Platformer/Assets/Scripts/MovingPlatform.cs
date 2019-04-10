using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private Vector3 _endPosition;
    [SerializeField] private bool _useLocalSpace = false;
    [SerializeField] private float _speed = 2.0f;
    [SerializeField] private int _loops = 0;
    [SerializeField] private LoopType _loopType = LoopType.Restart;
    [SerializeField] private Ease _easeType = Ease.Linear;

    public UnityEvent PositionReachedEvent;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 destination = _useLocalSpace ? transform.position + _endPosition : _endPosition;
        float duration = Vector3.Distance(transform.position, destination) / _speed;
        transform.DOMove(destination, duration)
            .SetLoops(_loops, _loopType)
            .SetEase(_easeType)
            .OnComplete(() => { PositionReachedEvent.Invoke(); });
    }

    private void OnDrawGizmosSelected()
    {
        Vector3 destination = _useLocalSpace ? transform.position + _endPosition : _endPosition;
        // Draw line to end position
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, destination);
    }
}
