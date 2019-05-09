using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Animator))]
public abstract class Unit : MonoBehaviour
{
    [SerializeField]
    private Renderer _renderer;

    public int TeamNumber = 0;

    protected Rigidbody _rigidbody;
    protected Animator _anim;

    protected void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
        SetTeam(TeamNumber);
        UnitAwake();
    }

    public void SetTeam(int teamNum)
    {
        TeamNumber = teamNum;
        Color teamColor = GameManager.Instance.TeamColors[teamNum];
        GetComponentInChildren<Renderer>().material.color = teamColor;
    }

    public abstract void UnitAwake();
}
