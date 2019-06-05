using UnityEngine;

public class PlayerController : Unit
{
    [SerializeField]
    private float _MoveSpeed = 5f;

    [SerializeField]
    private float _SprintSpeedMult = 5f;

    [SerializeField]
    private float _JumpSpeed = 12f;

    [SerializeField]
    private KeyCode _JumpKey = KeyCode.Space;

    [SerializeField]
    private KeyCode _SprintKey = KeyCode.LeftShift;

    [SerializeField]
    private Transform _CameraPivot;

    private Transform _PlayerCamera;
    private float _SpeedMult = 1.0f;
    private float _XInput;
    private float _ZInput;
    private bool _JumpPressed;
    private bool _SideWalk = false;
    private bool _BackWalk = false;
    private bool _ForwardWalk = false;

    public override void UnitAwake()
    {
        _PlayerCamera = GetComponentInChildren<Camera>().transform;
    }

    private void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        UpdateCameraZoom();

        if (IsAlive == false) return;

        ReadMoveInputs();
        SetAnimValues();
        UpdateRotations();
        ShootLasers();
    }

    private void ShootLasers()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = new Ray(_PlayerCamera.position, _PlayerCamera.forward);
            if (Physics.Raycast(ray, out var hit))
            {
                if (CanUnitSee(hit.point, hit.transform))
                {
                    ShootLasersFromEyes(hit.point, hit.transform);
                }
            }
        }
    }

    private void FixedUpdate()
    {
        if (IsAlive == false) return;

        ApplyMovePhysics();
    }

    private void ApplyMovePhysics()
    {
        var newVel = new Vector3(_XInput, 0f, _ZInput) * _MoveSpeed * _SpeedMult;

        newVel = transform.TransformVector(newVel);
        newVel.y = _JumpPressed ? _JumpSpeed : _RB.velocity.y;
        _RB.velocity = newVel;

        _JumpPressed = false;
    }

    private void CheckMovement()
    {
        if (_XInput < 0.0f || _XInput > 0.0f)
        {
            _SideWalk = true;
        }
        else if (_ZInput < 0.0f)
        {
            _BackWalk = true;
        }
        else if (_ZInput > 0.0f)
        {
            _ForwardWalk = true;
        }
        else
        {
            _ForwardWalk = false;
            _BackWalk = false;
            _SideWalk = false;
        }
    }

    private float SetSpeedMult()
    {
        float speed = 1.0f;
        if (_SideWalk && _ForwardWalk == false)
        {
            speed = 0.6f;
        }
        else if (_BackWalk || _SideWalk && _BackWalk)
        {
            speed = 0.3f;
        }

        return speed;
    }

    private void UpdateCameraZoom()
    {
        var newZoom = _PlayerCamera.localPosition;
        newZoom.z += Input.mouseScrollDelta.y;
        newZoom.z = Mathf.Clamp(newZoom.z, -24f, 0f);
        _PlayerCamera.localPosition = newZoom;
    }

    private void UpdateRotations()
    {
        var mouseX = Input.GetAxisRaw("Mouse X");
        var mouseY = Input.GetAxisRaw("Mouse Y");

        transform.Rotate(0f, mouseX, 0f);

        mouseY = Mathf.Clamp(mouseY, -90.0f, 90.0f);
        _CameraPivot.localRotation = Quaternion.Euler(-mouseY, 0.0f, 0.0f);
    }

    private void ReadMoveInputs()
    {
        _XInput = Input.GetAxis("Horizontal");
        _ZInput = Input.GetAxis("Vertical");
        CheckMovement();
        var speedDefault = SetSpeedMult();
        Debug.Log(speedDefault);
        _SpeedMult = Input.GetKey(_SprintKey) ? _SprintSpeedMult : speedDefault;
        if (Input.GetKeyDown(_JumpKey))
        {
            _JumpPressed = true;
            _Anim.SetTrigger("Jump");
        }
    }

    private void SetAnimValues()
    {
        _Anim.SetFloat("Horizontal", _XInput);
        _Anim.SetFloat("Vertical", _ZInput);
        _Anim.SetFloat("SpeedMult", _SpeedMult);
    }

}
