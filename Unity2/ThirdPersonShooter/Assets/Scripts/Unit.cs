using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Animator))]
public abstract class Unit : MonoBehaviour
{
    public int TeamNumber = 0;

    [SerializeField]
    protected Renderer _Rend;

    [SerializeField]
    protected Laser _LaserPrefab;

    [SerializeField]
    protected float _Health = 100f;

    [SerializeField]
    protected float _AttackDamage = 8f;

    protected Eye[] _Eyes;
    protected Rigidbody _RB;
    protected Animator _Anim;
    public bool IsAlive { get; protected set; } = true;


    public abstract void UnitAwake();

    protected void Awake()
    {
        _RB = GetComponent<Rigidbody>();
        _Anim = GetComponent<Animator>();
        _Eyes = GetComponentsInChildren<Eye>();

        UnitAwake();
    }

    protected void Start()
    {
        SetTeam(TeamNumber);
    }

    public void SetTeam(int teamNum)
    {
        TeamNumber = teamNum;
        Color teamColor = GameManager.Instance.TeamColors[TeamNumber - 1];
        _Rend.material.color = teamColor;
    }

    protected bool CanUnitSee(Vector3 hitPos, Transform other)
    {
        foreach (var eye in _Eyes)
        {
            var startPos = eye.transform.position;
            var dir = hitPos - startPos;
            var ray = new Ray(startPos, dir);
            if(Physics.Raycast(ray, out var hit) && hit.transform == other)
            {
                return true;
            }
        }
        return false;
    }

    protected void ShootLasersFromEyes(Vector3 hitPos, Transform other)
    {
        foreach (var eye in _Eyes)
        {
            Instantiate(_LaserPrefab).Shoot(eye.transform.position, hitPos);
        }

        var otherUnit = other.GetComponent<Unit>();
        if(otherUnit != null && otherUnit.TeamNumber != TeamNumber)
        {
            otherUnit.OnHit(_AttackDamage);
        }
    }

    public void OnHit(float damage)
    {
        _Health -= damage;
        if(_Health <= 0f)
        {
            _Health = 0f;
            Die();
        }
    }

    protected virtual void Die()
    {
        IsAlive = false;
        _Anim.SetBool("IsAlive", false);
    }

}
