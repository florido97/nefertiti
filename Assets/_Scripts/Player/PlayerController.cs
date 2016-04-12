using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    //Floats for the speed, in-Air additonal speed, JumpVelocity and time invincibilty after getting hit
    public float speed = 10, inAirSpeed = 8, JumpVelocity = 20, invincibleTimeAfterHurt = 3;

    //The layers the player will see as ground
    public LayerMask playerMask;

    //A bool the determins if the player can control the player sprite in the air
    public bool canMoveInAir = true;

    //A float that saves the velocity of the player
    private float savedVelocity = 0f;

<<<<<<< HEAD
<<<<<<< HEAD
    //The bools used for ground detection
    bool isGrounded = false, isOnLeft = false, isOnRight = false, playerIsInAir = true;

    //The AudioClip that will be the sound the player makes when it gets hurt
    public AudioClip hurtClip;

=======
>>>>>>> a2e5cebdb80f3a151cb2e239f1e9812668bcb4f5
=======
>>>>>>> a2e5cebdb80f3a151cb2e239f1e9812668bcb4f5
    //Transforms used to ground detection
    Transform myTrans, tagGround, tagLeft, tagRight;

    //The rigidbody of the players object
    Rigidbody2D rb;

    //The particleSystem on the player
    GameObject particleSys;

    //All the players colliders
    Collider2D[] myColls;

<<<<<<< HEAD
<<<<<<< HEAD
=======
    //The bools used for ground detection
    bool isGrounded = false, isOnLeft = false, isOnRight = false, playerIsInAir = true;

>>>>>>> a2e5cebdb80f3a151cb2e239f1e9812668bcb4f5
    //The animator the player uses, on the player sprite
    Animator ani;

    //The AudioSource that the player has
    AudioSource src;

=======
    //The bools used for ground detection
    bool isGrounded = false, isOnLeft = false, isOnRight = false, playerIsInAir = true;

    //The animator the player uses, on the player sprite
    Animator ani;

>>>>>>> a2e5cebdb80f3a151cb2e239f1e9812668bcb4f5
    void Start()
    {
        //Getting all the diffrent componets of the player
        myColls = gameObject.GetComponents<Collider2D>();
        myTrans = gameObject.GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        ani = GetComponentInChildren<Animator>();
        src = GetComponentInChildren<AudioSource>();

        //Searching for the ground detection tags.
        tagGround = GameObject.Find(this.name + "/tag_Ground").transform;
        tagLeft = GameObject.Find(this.name + "/tag_Left").transform;
        tagRight = GameObject.Find(this.name + "/tag_Right").transform;
    }

    void FixedUpdate()
    {
        //Checking if ground detection is true
        isGrounded = Physics2D.Linecast(myTrans.position, tagGround.position, playerMask);
        isOnLeft = Physics2D.Linecast(myTrans.position, tagLeft.position, playerMask);
        isOnRight = Physics2D.Linecast(myTrans.position, tagRight.position, playerMask);

        Move(Input.GetAxis("Horizontal"));
        //If none of the ground detection is hitting the ground the player is in the air
        if (!isGrounded && !isOnLeft && !isOnRight)
        {
            playerIsInAir = true;
<<<<<<< HEAD
<<<<<<< HEAD
            ani.SetBool("isOnGround", false);
=======
>>>>>>> a2e5cebdb80f3a151cb2e239f1e9812668bcb4f5
=======
>>>>>>> a2e5cebdb80f3a151cb2e239f1e9812668bcb4f5
        }
        else
        {
            playerIsInAir = false;
<<<<<<< HEAD
<<<<<<< HEAD
            ani.SetBool("isOnGround", true);
=======
>>>>>>> a2e5cebdb80f3a151cb2e239f1e9812668bcb4f5
=======
>>>>>>> a2e5cebdb80f3a151cb2e239f1e9812668bcb4f5
        }

        //Move function sending the contoller input as a float
        Move(Input.GetAxis("Horizontal"));
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> a2e5cebdb80f3a151cb2e239f1e9812668bcb4f5
=======

>>>>>>> a2e5cebdb80f3a151cb2e239f1e9812668bcb4f5
        ani.SetFloat("speed", Mathf.Abs(rb.velocity.x));
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
            ani.SetBool("isOnGround", false);
        }
    }

    void Move(float horizontalInput)
    {
        if (horizontalInput > 0)
        {
            transform.localScale = new Vector3(3, transform.localScale.y, transform.localScale.z);
        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> a2e5cebdb80f3a151cb2e239f1e9812668bcb4f5

        if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(-3, transform.localScale.y, transform.localScale.z);
        }

<<<<<<< HEAD
=======

        if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(-3, transform.localScale.y, transform.localScale.z);
        }

>>>>>>> a2e5cebdb80f3a151cb2e239f1e9812668bcb4f5
=======
>>>>>>> a2e5cebdb80f3a151cb2e239f1e9812668bcb4f5
        if (!canMoveInAir && playerIsInAir)
        {
            Vector2 airVelocity = rb.velocity;
            airVelocity.x = savedVelocity + (Input.GetAxis("Horizontal") * inAirSpeed);
            rb.velocity = airVelocity;
            return;
        }

        Vector2 moveVel = rb.velocity;
        moveVel.x = horizontalInput * speed;
        rb.velocity = moveVel;

        if (moveVel.x >= 1 || moveVel.x <= -1)
        {
            transform.Find("Particle System").gameObject.SetActive(true);
        }
        else
        {
            transform.Find("Particle System").gameObject.SetActive(false);
        }

    }

    public void Jump()
    {

        if (isGrounded || isOnLeft || isOnRight)
        {
            rb.velocity += JumpVelocity * Vector2.up;
            savedVelocity = Input.GetAxis("Horizontal") * speed;
        }
        transform.Find("Particle System").gameObject.SetActive(false);
    }

    void Hurt()
    {
        GlobalVars.playerHealth -= 10;
        TriggerHurt();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        EnemyWalking timidEnemy = coll.collider.GetComponent<EnemyWalking>();
        EnemyFollow agressiveEnemy = coll.collider.GetComponent<EnemyFollow>();
        if (timidEnemy != null || agressiveEnemy != null)
        {
            Hurt();
        }

    }

    public void TriggerHurt()
    {
        StartCoroutine(HurtBlinker());
    }

    IEnumerator HurtBlinker()
    {
        int enemyLayer = LayerMask.NameToLayer("Enemy");
        int playerLayer = LayerMask.NameToLayer("Player");
        Physics2D.IgnoreLayerCollision(enemyLayer, playerLayer);
        foreach (Collider2D collider in myColls)
        {
            collider.enabled = false;
            collider.enabled = true;
        }
<<<<<<< HEAD
<<<<<<< HEAD

        src.PlayOneShot(hurtClip);
=======
>>>>>>> a2e5cebdb80f3a151cb2e239f1e9812668bcb4f5
=======
>>>>>>> a2e5cebdb80f3a151cb2e239f1e9812668bcb4f5

        ani.SetLayerWeight(1, 1);

        yield return new WaitForSeconds(invincibleTimeAfterHurt);

        Physics2D.IgnoreLayerCollision(enemyLayer, playerLayer, false);
        ani.SetLayerWeight(1, 0);
    }
}