using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charController : MonoBehaviour
{
    // Variables for controlling movement
    public float speed = 5.0f;
    public float jumpForce = 5.0f;

    // Variables for controlling rotation
    public float rotationSpeed = 200.0f;

    // Reference to the CharacterController component
    private CharacterController controller;

    void Start()
    {
        // Get the CharacterController component attached to this object
        controller = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        // Move the character forward and backward
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * vertical * speed;

        // Rotate the character left and right
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, horizontal * rotationSpeed * Time.deltaTime, 0);

        // Apply movement to the CharacterController component
        controller.Move(movement * Time.deltaTime);

        // Make the character jump
        if (Input.GetButtonDown("Jump"))
        {
            controller.Move(Vector3.up * jumpForce * Time.deltaTime);
        }
    }
}
