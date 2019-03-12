using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Tuning")]
    [SerializeField]
    [Range(10.0f, 50.0f)]
    private float _moveSpeed = 5.0f;       // Move speed
    [SerializeField]
    private float _jumpForce = 500.0f;     // Jump Force
    [SerializeField]
    private string _flavorText = "Sample!";
    [SerializeField]
    private float _velocity = 0.0f; // Display speed of an object

    private Vector3 _input;                // Player input
    private Rigidbody _rigidbody;          // Rigidbody component attached
    private float _sprintSpeed = 1.0f; // Sprint speed

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Start()");

        // Get the rigidbody component
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        // Get player input
        _input = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

        // Get player jump input
        if (Input.GetButtonDown("Jump"))
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce);
        }

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) // If pressed shift
        {
            // Increasing speed
            _sprintSpeed = 1.5f;
        }
        else if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) // If pressed control
        {
            // Decreasing speed
            _sprintSpeed = 0.5f;
        }
        else
        {
            // Reset speed to default
            _sprintSpeed = 1.0f;
        }
    }

    // FixedUpdate is called once per Physics update (50 times/s)
    private void FixedUpdate()
    {
        // Move the gameObject based on input
        //transform.position += _input * _moveSpeed * Time.deltaTime;

        // Add force to rigidbody
        _rigidbody.AddForce(_input * _moveSpeed * _sprintSpeed);

        // Get velocity magnitude of an object
        _velocity = _rigidbody.velocity.magnitude;
    }
}
