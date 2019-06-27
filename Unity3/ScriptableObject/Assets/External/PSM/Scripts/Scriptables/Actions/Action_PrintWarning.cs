using UnityEngine;
using PSM;

[CreateAssetMenu(menuName = "PSM/Actions/Warning", fileName = "Warning_")]
public class Action_PrintWarning : PSMAction
{
    [SerializeField] private string _textToPrint;
    public override void Act(PluggableStateMachine psm)
    {
        Debug.LogWarning($"{psm.CurrentState.name} -> {_textToPrint}");
    }
}
