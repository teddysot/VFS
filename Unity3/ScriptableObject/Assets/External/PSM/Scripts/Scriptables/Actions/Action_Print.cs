using UnityEngine;
using PSM;

[CreateAssetMenu(menuName = "PSM/Actions/Print", fileName = "Print_")]
public class Action_Print : PSMAction
{
    [SerializeField] private string _textToPrint;
    public override void Act(PluggableStateMachine psm)
    {
        Debug.Log($"{psm.CurrentState.name} -> {_textToPrint}");
    }
}
