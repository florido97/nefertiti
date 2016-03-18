using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed = 0f, JumpVelocity = 10;
    public LayerMask playerMask;
    public bool canMoveInAir = true;
    Transform myTrans, tagGround, tagLeft, tagRight;
    Rigidbody2D rb;
    bool isGrounded = false;
    //bool isOnLeftWall = false;
    //bool isOnRightWall = false;

    Animator ani;

    // Use this for initialization
    void Start()
    {
        myTrans = gameObject.GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        tagGround = GameObject.Find(this.name + "/tag_ground").transform;
        //tagLeft = GameObject.Find(this.name + "/tag_left").transform;
        //tagRight = GameObject.Find(this.name + "/tag_right").transform;

        ani = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //
        isGrounded = Physics2D.Linecast(myTrans.position, tagGround.position, playerMask);
        //isOnLeftWall = Physics2D.Linecast(myTrans.position, tagLeft.position, playerMask);
        //isOnRightWall = Physics2D.Linecast(myTrans.position, tagRight.position, playerMask);

        Move(Input.GetAxis("Horizontal"));
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        ani.SetFloat("speed", Mathf.Abs(rb.velocity.x));
        Debug.Log(Mathf.Abs(rb.velocity.x));
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
        if (isGrounded /*|| isOnLeftWall || isOnRightWall*/)
        {
            rb.velocity += JumpVelocity * Vector2.up/*,ForceMode2D.Impulse*/;
        }
    }
}
