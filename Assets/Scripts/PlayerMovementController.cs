using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovementController : MonoBehaviour
{
    Rigidbody2D rb;
    public FlashlightController flashlight;
    public float moveForce = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (CrossPlatformInputManager.GetAxis("Horizontal") == 0 && CrossPlatformInputManager.GetAxis("Vertical") == 0 && rb.velocity != Vector2.zero)
        {
            rb.velocity = Vector2.zero;
        }
        else if (CrossPlatformInputManager.GetAxis("Horizontal") != 0 || CrossPlatformInputManager.GetAxis("Vertical") != 0)
        {
            Vector2 moveVector = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;
            //rb.AddForce(moveVector);
            rb.velocity = moveVector;

            float rot = Vector3.Angle(Vector3.up, moveVector);
            if (moveVector.x > 0)
            {
                rot = rot * -1;
            }

            flashlight.UpdateFlashlightDirection(rot);
        }
    }
}
