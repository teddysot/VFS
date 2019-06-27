using UnityEngine;

namespace PSM
{
    public abstract class PSMDecision : ScriptableObject
    {
        public abstract bool Decide(PluggableStateMachine psm);
    }
}
