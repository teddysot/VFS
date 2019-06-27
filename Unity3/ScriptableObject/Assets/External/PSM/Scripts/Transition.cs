using UnityEngine;

namespace PSM
{
    [System.Serializable]
    public class Transition 
    {
        [Tooltip("All Decisions are AND-ed")]
        [SerializeField] private PSMDecision[] _decisions;
        [SerializeField] private State _stateToTransitionIfTrue;
        [SerializeField] private State _stateToTransitionIfFalse;

        public void ExecuteChecks(PluggableStateMachine psm)
        {
            foreach (var item in _decisions)
            {
                if(item.Decide(psm) == false)
                {
                    psm.ChangeState(_stateToTransitionIfFalse);
                    return;
                }
            }

            psm.ChangeState(_stateToTransitionIfTrue);
        }
    }
}
