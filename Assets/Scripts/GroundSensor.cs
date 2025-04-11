using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool IsGrounded;
    private Animator _animator;

    void Awake()
    {
        _animator = GetComponentInParent<Animator>();
    }

    void OnTriggerEneter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 3)
        {
            IsGrounded = true;
            _animator.SetBool("IsJumping", false);
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 3)
        {
            IsGrounded = true;
            _animator.SetBool("IsJumping", false);
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        IsGrounded = false;
        _animator.SetBool("IsJumping", true);
    }
}
