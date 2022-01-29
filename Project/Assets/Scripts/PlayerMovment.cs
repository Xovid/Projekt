using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float movespeed;
    public float jumpforce;
    public Transform cellingcheck;
    public Transform groundcheck;
    public LayerMask groundObjects;
    public float checkRadius;
    public int maxJumpCount;

    private Rigidbody2D rb;
    private bool facingRight = true;
    private float moveDirecton;
    private bool isJumping = false;
    private bool isGrounded;
    private int jumpCount;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        jumpCount = maxJumpCount;

    }
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundcheck.position, checkRadius, groundObjects);
        if (isGrounded)
        {
            jumpCount = maxJumpCount;
        }

        Move();
    }

    void Update()
    {
        ProcesInputs();

        Animate();

        
    }

    private void Move()
    {
        rb.velocity = new Vector2(moveDirecton * movespeed, rb.velocity.y);
        if(isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpforce));
            jumpCount--;
        }
        isJumping = false;
    }

    private void ProcesInputs()
    {
        moveDirecton = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            isJumping = true;
        }
    }

    private void Animate()
    {
        if (moveDirecton > 0 && !facingRight)
        {
            FlipCharacter();
        }
        else if (moveDirecton < 0 && facingRight)
        {
            FlipCharacter();
        }
    }

    private void FlipCharacter()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}