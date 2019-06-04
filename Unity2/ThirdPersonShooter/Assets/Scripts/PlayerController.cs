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
    private float _SpeedMult;
    private float _XInput;
    private float _ZInput;
    private bool _JumpPressed;

    public override void UnitAwake()
    {
        _PlayerCamera = GetComponentInChildren<Camera>().transform;
    }

    private void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        UpdateCameraZoom();

        if(IsAlive == false) return;

        ReadMoveInputs();
        SetAnimValues();
        UpdateRotations();
        ShootLasers();
    }

    private void ShootLasers()
    {
        if(Input.GetMouseButtonDown(0))
        {
            var ray = new Ray(_PlayerCamera.position, _PlayerCamera.forward);
            if(Physics.Raycast(ray, out var hit))
            {
                if(CanUnitSee(hit.point, hit.transform))
                {
                    ShootLasersFromEyes(hit.point, hit.transform);
                }
            }
        }
    }

    private void FixedUpdate()
    {
        if(IsAlive == false) return;
        
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
        _CameraPivot.Rotate(-mouseY, 0f, 0f);
    }

    private void ReadMoveInputs()
    {
        _XInput = Input.GetAxis("Horizontal");
        _ZInput = Input.GetAxis("Vertical");
        _SpeedMult = Input.GetKey(_SprintKey) ? _SprintSpeedMult : 1f;
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
