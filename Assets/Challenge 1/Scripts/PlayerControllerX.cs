using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 20.0f;
    private float rotationSpeed = 45.0f;
    private float verticalInput;
    private float horizontalInput;

    private float maxSpeed = 50.0f; // Maximum speed
    private float acceleration = 5.0f; // Acceleration factor
    private float deceleration = 2.0f; // Deceleration factor (slowdown)

    void FixedUpdate()
    {
        // Obtain vertical and horizontal user input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // If the user presses a button, the aircraft accelerates
        if (verticalInput != 0)
        {
            speed += verticalInput * acceleration * Time.deltaTime;
        }
        else
        {
            // Slow the aircraft down gradually when there is no entry
            speed -= deceleration * Time.deltaTime;
        }

        // Limit speed between 0 and maxSpeed
        speed = Mathf.Clamp(speed, 0, maxSpeed);

        // Move the aircraft at a constant speed
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Rotate the aircraft vertically using the up/down keys
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);

        // Rotate the aircraft horizontally using the left/right keys
        transform.Rotate(Vector3.up * rotationSpeed * horizontalInput * Time.deltaTime);
    }
}