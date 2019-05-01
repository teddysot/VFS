using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private IState _currentState;

    public void ChangeState(IState newState)
    {
        if(_currentState != null)
        {
            _currentState.Exit();
        }

#if UNITY_EDITOR
        Debug.Log("[StateMachine] ChangeState: " + newState.ToString());
#endif
        _currentState = newState;
    }

    public void ExecuteState()
    {
        IState runningState = _currentState;

        if(runningState != null)
        {
#if UNITY_EDITOR
            Debug.Log("[StateMachine] ExecuteState: " + runningState.ToString());
#endif
            runningState.Execute();
        }
    }
}
