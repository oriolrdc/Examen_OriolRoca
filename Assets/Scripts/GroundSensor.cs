using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool IsGrounded;

    void OnTriggerEneter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 3)
        {
            IsGrounded = true;
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 3)
        {
            IsGrounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        IsGrounded = false;
    }
}
