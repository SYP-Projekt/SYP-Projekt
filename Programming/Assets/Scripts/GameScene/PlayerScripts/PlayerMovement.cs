using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    float speed = 12f;
    public float sprintSpeed = 18f;
    public float sneakSpeed = 5f;
    public float walkSpeed = 12f;

    Vector3 velocity;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y <0)
        {
            velocity.y = -2f;
        }

        if(Input.GetKey(KeyCode.LeftShift) == true)
        {
            speed = sprintSpeed;
        }
        else if(Input.GetKey(KeyCode.LeftControl) == true)
        {
            speed = sneakSpeed;
        } else
        {
            speed = walkSpeed;
        }

        Vector3 move = transform.right * x + transform.forward * z;


        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
