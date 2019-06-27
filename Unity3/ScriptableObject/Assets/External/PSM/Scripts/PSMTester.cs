using PSM;
using UnityEngine;

public class PSMTester : MonoBehaviour
{
    [SerializeField] private State _defaultState;

    private PluggableStateMachine _psm;

    private void Awake() 
    {
        _psm = new PluggableStateMachine(gameObject, _defaultState);
    }

    private void Update() 
    {
        _psm.Update();
    }
}
