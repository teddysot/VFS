using System.Collections.Generic;
using UnityEngine;

public class Outpost : MonoBehaviour
{
    public static List<Outpost> OutpostList = new List<Outpost>();

    public float CaptureValue { get; private set; }
    public int CurrentTeam { get; private set; }
    public int CurrentControlledTeam { get; private set; }
    public int PreviousControlledTeam { get; private set; }

    [SerializeField, Tooltip("Time in Seconds")]
    private float _CaptureTime = 5f;

    private SkinnedMeshRenderer _FlagRend;

    private void OnEnable()
    {
        _FlagRend = GetComponentInChildren<SkinnedMeshRenderer>();
        if (OutpostList.Contains(this)) return;
        OutpostList.Add(this);
    }

    private void OnDisable()
    {
        if (OutpostList.Contains(this) == false) return;
        OutpostList.Remove(this);
    }

    private void OnTriggerStay(Collider other)
    {
        var unit = other.GetComponent<Unit>();
        if (unit == null || unit.IsAlive == false)
        {
            return;
        }

        if (unit.TeamNumber == CurrentTeam)
        {
            CaptureValue += Time.fixedDeltaTime / _CaptureTime;
            if (CaptureValue > 1f)
            {
                CaptureValue = 1f;
                if(PreviousControlledTeam != CurrentControlledTeam)
                {
                    PreviousControlledTeam = CurrentControlledTeam;
                }
                CurrentControlledTeam = CurrentTeam;

                int curTeamIdx = CurrentControlledTeam - 1;
                GameManager.Instance.OutpostCaputured[curTeamIdx] += 1;

                int prevTeamIdx = PreviousControlledTeam - 1;
                if (prevTeamIdx >= 0)
                {
                    GameManager.Instance.OutpostCaputured[prevTeamIdx] -= 1;

                    if (GameManager.Instance.OutpostCaputured[prevTeamIdx] < 0)
                    {
                        GameManager.Instance.OutpostCaputured[prevTeamIdx] = 0;
                    }
                }
            }
        }
        else
        {
            CaptureValue -= Time.fixedDeltaTime / _CaptureTime;
            if (CaptureValue <= 0f)
            {
                CaptureValue = 0f;
                CurrentTeam = unit.TeamNumber;
            }
        }
    }

    private void Update()
    {
        var color = CheckTeamColor();
        var teamColor = GameManager.Instance.TeamColors[color];
        _FlagRend.material.color = Color.Lerp(Color.white, teamColor, CaptureValue);
    }

    private int CheckTeamColor()
    {
        int colorIdx = 0;
        if (CurrentTeam > 0)
        {
            colorIdx = CurrentTeam - 1;
        }
        return colorIdx;
    }

}
