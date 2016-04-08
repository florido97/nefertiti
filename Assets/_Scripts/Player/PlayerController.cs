using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed = 10, inAirSpeed = 8, JumpVelocity = 20, invincibleTimeAfterHurt = 3;
    public LayerMask playerMask;
    public bool canMoveInAir = true;

    public float savedVelocity = 0f;

    Transform myTrans, tagGround, tagLeft, tagRight;
    Rigidbody2D rb;
    GameObject particleSys;
    Collider2D[] myColls;

    bool isGrounded = false, isOnLeft = false, isOnRight = false;
    Animator ani;

    void Start()
    {
        myColls = gameObject.GetComponents<Collider2D>();
        myTrans = gameObject.GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        ani = GetComponentInChildren<Animator>();

        tagGround = GameObject.Find(this.name + "/tag_Ground").transform;
        tagLeft = GameObject.Find(this.name + "/tag_Left").transform;
        tagRight = GameObject.Find(this.name + "/tag_Right").transform;
    }

    void FixedUpdate()
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

        ani.SetFloat("speed", Mathf.Abs(rb.velocity.x));

    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Move(float horizontalInput)
    {

        if (!canMoveInAir && !isGrounded && !isOnLeft && !isOnRight)
        {
            Vector2 airVelocity = rb.velocity;
            airVelocity.x = savedVelocity + (Input.GetAxis("Horizontal") * inAirSpeed);
            rb.velocity = airVelocity;
            //ani.SetBool("isGround", false);
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
            //ani.SetBool("isround", true);
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
