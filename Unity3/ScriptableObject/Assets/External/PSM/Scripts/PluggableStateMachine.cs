using UnityEngine;

namespace PSM
{
    public class PluggableStateMachine
    {
        public GameObject Owner { get; private set; }
        public State CurrentState { get; private set; }
        public bool IsActive { get; private set; }

        public PluggableStateMachine(GameObject owner, State defaultState)
        {
            Owner = owner;
            ChangeState(defaultState);
            IsActive = true;
        }

        public void ChangeState(State newState)
        {
            if (newState == null)
            {
                return;
            }

            if (CurrentState != null)
            {
                CurrentState.OnStateExit(this);
            }

            CurrentState = newState;
            CurrentState.OnStateEnter(this);
        }

        public void Update() 
        {
            if(IsActive == false || CurrentState == null)
            {
                return;
            }

            CurrentState.OnStateUpdate(this);
        }
    }
}

