﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed = 0f, JumpVelocity = 10;
    public LayerMask playerMask;
    public bool canMoveInAir = true;
    Transform myTrans, tagGround, tagLeft, tagRight;
    Rigidbody2D rb;
    bool isGrounded = false;
    bool isOnLeft = false;
    bool isOnRight = false;

    Animator ani;

    // Use this for initialization
    void Start()
    {
        myTrans = gameObject.GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody2D>();

        ani = GetComponentInChildren<Animator>();

        tagGround = GameObject.Find(this.name + "/tag_Ground").transform;
        tagLeft = GameObject.Find(this.name + "/tag_Left").transform;
        tagRight = GameObject.Find(this.name + "/tag_Right").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //
        isGrounded = Physics2D.Linecast(myTrans.position, tagGround.position, playerMask);
        isOnLeft = Physics2D.Linecast(myTrans.position, tagLeft.position, playerMask);
        isOnRight = Physics2D.Linecast(myTrans.position, tagRight.position, playerMask);

        Move(Input.GetAxis("Horizontal"));
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        ani.SetFloat("speed", Mathf.Abs(rb.velocity.x));

        CheckIfGrounded();
    }

    void Move(float horizontalInput)
    {
        if (!canMoveInAir && !isGrounded)
            return;
        

        Vector2 moveVel = rb.velocity;
        moveVel.x = horizontalInput * speed;
        rb.velocity = moveVel;
    }

    public void Jump()
    {
        if (isGrounded || isOnLeft || isOnRight)
        {
            rb.velocity += JumpVelocity * Vector2.up/*,ForceMode2D.Impulse*/;
            //rb.AddForce(0, 0, thrust, ForceMode.Impulse);
        }
    }

    void CheckIfGrounded()
    {
        if (!isGrounded)
        {
            ani.SetBool("Grounded", false);
        }

        else
        {
            ani.SetBool("Grounded", true);
        }
    }
}
