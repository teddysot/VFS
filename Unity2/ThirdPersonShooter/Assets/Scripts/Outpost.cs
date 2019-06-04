using System.Collections.Generic;
using UnityEngine;

public class Outpost : MonoBehaviour
{
    public static List<Outpost> OutpostList = new List<Outpost>();

    public float CaptureValue { get; private set; }
    public int CurrentTeam { get; private set; }

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
        if(unit == null || unit.IsAlive == false)
        {
            return;
        }

        if(unit.TeamNumber == CurrentTeam)
        {
            CaptureValue += Time.fixedDeltaTime / _CaptureTime;
            if(CaptureValue > 1f) CaptureValue = 1f;
        }
        else
        {
            CaptureValue -= Time.fixedDeltaTime / _CaptureTime;
            if(CaptureValue <= 0f)
            {
                CaptureValue = 0f;
                CurrentTeam = unit.TeamNumber;
            }
        }
    }

    private void Update()
    {
        var teamColor = GameManager.Instance.TeamColors[CurrentTeam];
        _FlagRend.material.color = Color.Lerp(Color.white, teamColor, CaptureValue);
    }

}
