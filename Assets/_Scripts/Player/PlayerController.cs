using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    //Floats for the speed, JumpVelocity and time invincibilty after getting hit
    public float speed = 0f, JumpVelocity = 10, invincibleTimeAfterHurt = 3;

    //The layers the player can interact with
    public LayerMask playerMask;

    //A bool the determins if the player can control the player sprite in the air
    public bool canMoveInAir = true;

    //Transforms used to ground detection
    Transform myTrans, tagGround, tagLeft, tagRight;

    //The rigidbody of the players object
    Rigidbody2D rb;

    //The particleSystem on the player
    GameObject particleSys;

    //All the players colliders
    Collider2D[] myColls;

    //The bools used for ground detection
    bool isGrounded = false, isOnLeft = false, isOnRight = false;

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

    void Update()
    {
        isGrounded = Physics2D.Linecast(myTrans.position, tagGround.position, playerMask);
        isOnLeft = Physics2D.Linecast(myTrans.position, tagLeft.position, playerMask);
        isOnRight = Physics2D.Linecast(myTrans.position, tagRight.position, playerMask);


        Move(Input.GetAxis("Horizontal"));

        float h = Input.GetAxis("Horizontal");

        if (h > 0)
        {
            transform.localScale = new Vector3(3, transform.localScale.y, transform.localScale.z);
        }

        if (h < 0)
        {
            transform.localScale = new Vector3(-3, transform.localScale.y, transform.localScale.z);
        }

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        ani.SetFloat("speed", Mathf.Abs(rb.velocity.x));

    }

    void Move(float horizontalInput)
    {
        if (!canMoveInAir && !isGrounded && !isOnLeft && !isOnRight)
            return;
        

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
