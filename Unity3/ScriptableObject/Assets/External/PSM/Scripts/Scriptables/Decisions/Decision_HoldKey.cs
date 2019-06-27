using UnityEngine;
using PSM;

[CreateAssetMenu(menuName = "PSM/Decisions/HoldKey", fileName = "HoldKey_")]
public class Decision_HoldKey : PSMDecision
{
    [SerializeField] private KeyCode _keyToHold;

    public override bool Decide(PluggableStateMachine psm)
    {
        return Input.GetKey(_keyToHold);
    }
}
