using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    private Vector3 velocity;
    private Vector3 moveInput;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    private bool isGrounded;

    void Start()
    {
        //Hide Cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Ground Check
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0f)
        {
            velocity.y = -2f;
        }

        // Movement
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.z = Input.GetAxis("Vertical");
        moveInput.Normalize();

        Vector3 move = transform.right * moveInput.x + transform.forward * moveInput.z;
        controller.Move(move * speed * Time.deltaTime);

        // Jump & Gravity
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}