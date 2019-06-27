using UnityEngine;
using PSM;

[CreateAssetMenu(menuName = "PSM/Actions/Error", fileName = "Error_")]
public class Action_PrintError : PSMAction
{
    [SerializeField] private string _textToPrint;
    public override void Act(PluggableStateMachine psm)
    {
        Debug.LogError($"{psm.CurrentState.name} -> {_textToPrint}");
    }
}
