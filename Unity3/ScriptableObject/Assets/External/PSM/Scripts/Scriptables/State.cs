using UnityEngine;

namespace PSM
{
    [CreateAssetMenu(menuName = "PSM/State", fileName = "State_")]
    public class State : ScriptableObject
    {
        [SerializeField] private PSMAction [] _enterStateActions;
        [SerializeField] private PSMAction [] _updateStateActions;
        [SerializeField] private PSMAction [] _exitStateActions;

        [Tooltip("All Transitions are OR ed")]
        [SerializeField] private Transition [] _transitions;

        public void OnStateEnter(PluggableStateMachine psm) 
        {
            ExecuteActions(_enterStateActions, psm);
        }

        public void OnStateUpdate(PluggableStateMachine psm) 
        {
            ExecuteActions(_updateStateActions, psm);
            CheckTransitions(_transitions, psm);
        }

        public void OnStateExit(PluggableStateMachine psm) 
        {
            ExecuteActions(_exitStateActions, psm);
        }

        private void ExecuteActions(PSMAction[] actions, PluggableStateMachine psm)
        {
            for(int i = 0; i < actions.Length; ++i)
            {
                actions[i].Act(psm);
            }
        }

        private void CheckTransitions(Transition[] transitions, PluggableStateMachine psm)
        {
            for(int i = 0; i < transitions.Length; ++i)
            {
                transitions[i].ExecuteChecks(psm);
            }
        }
    }
}
