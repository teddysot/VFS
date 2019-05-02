using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private int _PlayerScore;
    [SerializeField] private float _PlayerHealth;
    [SerializeField] private float _MoveSpeed = 5.0f;
    [SerializeField] private float _SprintSpeedMultiply = 5.0f;
    [SerializeField] private float _JumpSpeed = 12.0f;
    [SerializeField] KeyCode _JumpKey = KeyCode.Space;
    [SerializeField] KeyCode _SprintKey = KeyCode.LeftShift;
    [SerializeField] Transform _CameraPivot;

    private Animator _Animator;
    private Rigidbody _RigidBody;
    private Transform _PlayerCamera;
    private float _SpeedMultiply;
    private float _XInput;
    private float _ZInput;
    private bool _JumpPressed;


    private void Awake()
    {
        _Animator = GetComponent<Animator>();
        _RigidBody = GetComponent<Rigidbody>();
        _PlayerCamera = GetComponentInChildren<Camera>().transform;
        Cursor.visible = false;
    }

    private void Update()
    {
        CursorVisible();
        InputMovement();
        UpdateRotations();
        UpdateCameraZoom();
    }

    private void FixedUpdate()
    {
        ApplyMovePhysics();
        SetAnimValues();
    }

    private static void CursorVisible()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Cursor.visible = !Cursor.visible;
        }
    }

    private void UpdateCameraZoom()
    {
        Vector3 newZoom = _PlayerCamera.localPosition;
        newZoom.z += Input.mouseScrollDelta.y;
        newZoom.z = Mathf.Clamp(newZoom.z, -24.0f, -3.0f);
        _PlayerCamera.localPosition = newZoom;
    }

    private void UpdateRotations()
    {
        float MouseX = Input.GetAxisRaw("Mouse X");
        float MouseY = Input.GetAxisRaw("Mouse Y");

        transform.Rotate(0.0f, MouseX, 0.0f);
        _CameraPivot.Rotate(-MouseY, 0.0f, 0.0f);
    }

    private void InputMovement()
    {
        _XInput = Input.GetAxis("Horizontal");
        _ZInput = Input.GetAxis("Vertical");
        _JumpPressed |= Input.GetKeyDown(_JumpKey);
        _SpeedMultiply = Input.GetKey(_SprintKey) ? _SprintSpeedMultiply : 1.0f;

        if(_JumpPressed)
        {
            _Animator.SetTrigger("Jump");
        }
    }

    private void ApplyMovePhysics()
    {
        Vector3 newVelocity = new Vector3(_XInput, 0.0f, _ZInput) * _MoveSpeed * _SpeedMultiply;
        newVelocity = transform.TransformVector(newVelocity);
        newVelocity.y = _JumpPressed ? _JumpSpeed : _RigidBody.velocity.y;
        _RigidBody.velocity = newVelocity;

        _JumpPressed = false;
    }

    private void SetAnimValues()
    {
        _Animator.SetFloat("Horizontal", _XInput);
        _Animator.SetFloat("Vertical", _ZInput);
        _Animator.SetFloat("SpeedMult", _SpeedMultiply);
    }
}
