using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public BirdCounter counter;
    public CharacterController2D controller;
    public Animator animator;

    float horizontalMove = 0;
    public float runSpeed = 10f;
    bool jumpbl = false;
    bool crouchbl = false;

    private void Start()
    {
        
    }

    private void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jumpbl = true;
            animator.SetBool("Jump", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouchbl = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouchbl = false;
        }
    }

    public void onLanding()
    {
        animator.SetBool("Jump", false);
    }

    public void onCrouching(bool isCrouching)
    {
        animator.SetBool("Crouch", isCrouching);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Bird"))
        {
            if (collision.gameObject.name.Contains("Owl"))
            {
                counter.increaseOwl();
            }
            else if (collision.gameObject.name.Contains("Chicken"))
            {
                counter.increaseChick();
            }
            else
            {
                counter.increaseEag();
            }
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove*Time.fixedDeltaTime, crouchbl, jumpbl);
        jumpbl = false;
    }
}
