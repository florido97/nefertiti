using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    //Floats for the speed, in-Air additonal speed, JumpVelocity and time invincibilty after getting hit
    public float speed = 10, inAirSpeed = 8, JumpVelocity = 20, invincibleTimeAfterHurt = 3;
    //The layers the player will see as ground
=======
<<<<<<< HEAD
=======
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
=======
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
    //Floats for the speed, JumpVelocity and time invincibilty after getting hit
    public float speed = 0f, JumpVelocity = 10, invincibleTimeAfterHurt = 3;

    //The layers the player can interact with
=======

    public float speed = 10, inAirSpeed = 8, JumpVelocity = 20, invincibleTimeAfterHurt = 3;
>>>>>>> origin/master
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> origin/master
    public LayerMask playerMask;

    //A bool the determins if the player can control the player sprite in the air
    public bool canMoveInAir = true;
    
    //A float that saves the velocity of the player
    private float savedVelocity = 0f;

<<<<<<< HEAD
    //Transforms used to ground detection
=======
=======
=======
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
    public LayerMask playerMask;

    //A bool the determins if the player can control the player sprite in the air
    public bool canMoveInAir = true;

<<<<<<< HEAD
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
=======
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
<<<<<<< HEAD
    //Transforms used to ground detection
=======
    public float savedVelocity = 0f;

>>>>>>> origin/master
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> origin/master
=======
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
=======
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
    Transform myTrans, tagGround, tagLeft, tagRight;

    //The rigidbody of the players object
    Rigidbody2D rb;

    //The particleSystem on the player
    GameObject particleSys;

    //All the players colliders
    Collider2D[] myColls;

    //The bools used for ground detection
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    bool isGrounded = false, isOnLeft = false, isOnRight = false, playerIsInAir = true;
    
=======
    bool isGrounded = false, isOnLeft = false, isOnRight = false;

>>>>>>> origin/master
=======
    bool isGrounded = false, isOnLeft = false, isOnRight = false;

>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
=======
    bool isGrounded = false, isOnLeft = false, isOnRight = false;

>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
    //The animator the player uses, on the player sprite
    Animator ani;

    void Start()
    {
        //Getting all the diffrent componets of the player
        myColls = gameObject.GetComponents<Collider2D>();
        myTrans = gameObject.GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        ani = GetComponentInChildren<Animator>();

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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
=======
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5


        Move(Input.GetAxis("Horizontal"));
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5


        Move(Input.GetAxis("Horizontal"));
>>>>>>> origin/master

        //If none of the ground detection is hitting the ground the player is in the air
        if (!isGrounded && !isOnLeft && !isOnRight)
        {
            playerIsInAir = true;
        }
        else
        {
            playerIsInAir = false;
        }

<<<<<<< HEAD
<<<<<<< HEAD
        //Move function sending the contoller input as a float
        Move(Input.GetAxis("Horizontal"));
        
        ani.SetFloat("speed", Mathf.Abs(rb.velocity.x));
        if (!playerIsInAir)
=======
=======
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
        ani.SetFloat("speed", Mathf.Abs(rb.velocity.x));

    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
        {
            Debug.Log("Derp is in air");
            ani.SetBool("isOnGround", true);
        }
<<<<<<< HEAD
<<<<<<< HEAD
    }

<<<<<<< HEAD
    //put jump in update so there is no delay
=======
        ani.SetFloat("speed", Mathf.Abs(rb.velocity.x));

=======
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
    }

>>>>>>> origin/master
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
            ani.SetBool("isOnGround", false);
        }
=======
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
    }

    void Move(float horizontalInput)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        if (horizontalInput > 0)
        {
            transform.localScale = new Vector3(3, transform.localScale.y, transform.localScale.z);
        }

        if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(-3, transform.localScale.y, transform.localScale.z);
        }
        
        if (canMoveInAir == false && playerIsInAir == true)
        //if (!canMoveInAir && playerIsInAir)
  
=======

        if (!canMoveInAir && !isGrounded && !isOnLeft && !isOnRight)
>>>>>>> origin/master
=======

        if (!canMoveInAir && !isGrounded && !isOnLeft && !isOnRight)
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
=======

        if (!canMoveInAir && !isGrounded && !isOnLeft && !isOnRight)
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
        {
            Vector2 airVelocity = rb.velocity;
            airVelocity.x = savedVelocity + (Input.GetAxis("Horizontal") * inAirSpeed);
            rb.velocity = airVelocity;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
            //ani.SetBool("isGround", false);
>>>>>>> origin/master
=======
            //ani.SetBool("isGround", false);
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
=======
            //ani.SetBool("isGround", false);
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
            //ani.SetBool("isround", true);
>>>>>>> origin/master
=======
            //ani.SetBool("isround", true);
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
=======
            //ani.SetBool("isround", true);
>>>>>>> f1e50ee1d88b4834831786627099b406670546b5
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

        ani.SetLayerWeight(1, 1);

        yield return new WaitForSeconds(invincibleTimeAfterHurt);

        Physics2D.IgnoreLayerCollision(enemyLayer, playerLayer, false);
        ani.SetLayerWeight(1, 0);
    }
}
