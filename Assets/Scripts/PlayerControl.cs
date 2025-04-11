using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    public float inputHorizontal;
    public float playerSpeed = 4.5f;
    public float jumpForce = 12;
    private GroundSensor groundSensor;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        groundSensor = GetComponentInChildren<GroundSensor>();
    }

    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");

        if(inputHorizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if(inputHorizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if(Input.GetButtonDown("Jump") && groundSensor.IsGrounded == true)
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        _rigidBody.velocity = new Vector2(inputHorizontal * playerSpeed, _rigidBody.velocity.y);
    }

    void Jump()
    {
        _rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
