using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed = 0f, JumpVelocity = 10, invincibleTimeAfterHurt = 3;
    public LayerMask playerMask;
    public bool canMoveInAir = true;

    Transform myTrans, tagGround, tagLeft, tagRight;
    Rigidbody2D rb;
    GameObject particleSys;
    Collider2D[] myColls;

<<<<<<< HEAD
    int _offset = 4;

=======
    bool isGrounded = false, isOnLeft = false, isOnRight = false;
>>>>>>> b20b94420e0d568f033d0a35fd129021fb9844e6
    Animator ani;

    GameObject hand;

    // Use this for initialization
    void Start()
    {
        myColls = gameObject.GetComponents<Collider2D>();
        myTrans = gameObject.GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        ani = GetComponentInChildren<Animator>();

        tagGround = GameObject.Find(this.name + "/tag_Ground").transform;
        tagLeft = GameObject.Find(this.name + "/tag_Left").transform;
        tagRight = GameObject.Find(this.name + "/tag_Right").transform;
        hand = GameObject.Find(name + "/player/hand attack");
        hand.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        rotateHand();
        isGrounded = Physics2D.Linecast(myTrans.position, tagGround.position, playerMask);
        isOnLeft = Physics2D.Linecast(myTrans.position, tagLeft.position, playerMask);
        isOnRight = Physics2D.Linecast(myTrans.position, tagRight.position, playerMask);
        //Debug.Log("Left is: " + isOnLeft + ", OnGround is: " + isGrounded + ", Right is: " + isOnRight);
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

        CheckIfGrounded();

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
            rb.velocity += JumpVelocity * Vector2.up/*,ForceMode2D.Impulse*/;
            //rb.AddForce(0, 0, thrust, ForceMode.Impulse);
            //gameObject.GetChild("childname").SetActive(false);
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

    public void SetAttacking(bool B)
    {
        ani.SetBool("offsetOn", B);
        hand.SetActive(B);
    }

    void rotateHand()
    {
        if (hand.activeInHierarchy == true)
        {
            hand.transform.Translate
            
        }
    }
}
