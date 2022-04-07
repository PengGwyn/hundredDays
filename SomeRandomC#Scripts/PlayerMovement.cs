using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private protected float moveSpeed = 5f;
    [SerializeField] private protected float jumpForce = 15f;

    private Rigidbody2D rb;

    private Vector2 moveInput; 
    private bool isGrounded = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();   
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInput.x * moveSpeed, rb.velocity.y);
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    public void SetIsGrounded(bool condition)
    {
        isGrounded = condition;
    }
}
