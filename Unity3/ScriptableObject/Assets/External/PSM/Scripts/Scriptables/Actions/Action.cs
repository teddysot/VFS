using UnityEngine;

namespace PSM
{
    public abstract class PSMAction : ScriptableObject
    {
        public abstract void Act(PluggableStateMachine psm);
    }
}