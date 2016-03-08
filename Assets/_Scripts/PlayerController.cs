using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed = 0f, JumpVelocity = 10;
    public LayerMask playerMask;
    public bool canMoveInAir = true;
    Transform myTrans, tagGround;
    Rigidbody2D rb;
    bool isGrounded = false;

    // Use this for initialization
    void Start()
    {
        myTrans = gameObject.GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        tagGround = GameObject.Find(this.name + "/tag_ground").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //
        isGrounded = Physics2D.Linecast(myTrans.position, tagGround.position, playerMask);

        Move(Input.GetAxis("Horizontal"));
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
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
        if (isGrounded)
        {
            rb.velocity += JumpVelocity * Vector2.up/*,ForceMode2D.Impulse*/;
        }
    }
}
