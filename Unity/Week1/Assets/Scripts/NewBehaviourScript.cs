using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Header("Movement Tuning")]
    [SerializeField] [Range(10.0f, 50.0f)]
    private float _moveSpeed = 5.0f;       // Move speed
    [SerializeField]
    private float _jumpForce = 500.0f;     // Jump Force
    [SerializeField]
    private string _flavorText = "It's dangerous to go alone!";

    private Vector3 _input;                // Player input
    private Rigidbody _rigidbody;          // Rigidbody component attached

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
        _input = new Vector3(Input.GetAxis("Horizontal"), 0.0f , Input.GetAxis("Vertical"));

        // Get player jump input
        if(Input.GetButtonDown("Jump"))
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce);
        }
    }

    // FixedUpdate is called once per Physics update (50 times/s)
    private void FixedUpdate()
    {
        // Move the gameObject based on input
        //transform.position += _input * _moveSpeed * Time.deltaTime;

        // Add force to rigidbody
        _rigidbody.AddForce(_input * _moveSpeed);
    }
}
