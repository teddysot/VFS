using UnityEngine;
using PSM;

[CreateAssetMenu(menuName = "PSM/Decisions/PressKey", fileName = "PressKey_")]
public class Decision_PressKey : PSMDecision
{
    [SerializeField] private KeyCode _keyToPress;

    public override bool Decide(PluggableStateMachine psm)
    {
        return Input.GetKeyDown(_keyToPress);
    }
}
