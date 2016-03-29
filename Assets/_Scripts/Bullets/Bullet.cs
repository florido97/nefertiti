using UnityEngine;
using System.Collections;

<<<<<<< HEAD
/*public class Bullet : MonoBehaviour {
=======
/*public class Bullet : MonoBehaviour
{
>>>>>>> origin/master

    private GameObject player;
    private Rigidbody2D rb;

    [SerializeField]
    private float bulletSpeed = 10;

    [SerializeField]
    private bool followPlayer = false;

    void Start()
    {
        player = GameObject.Find(Tags.playerObject);
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Scatter());

        if (followPlayer == true)
        {
            rb.gravityScale = 0;
        }

        else {
            rb.gravityScale = 3;
        }
    }

    void Update()
    {
        if (followPlayer == true)
            rb.AddForce(((player.transform.position - transform.position) * bulletSpeed), ForceMode2D.Force);

        Rotate();
        //transform.rotation = Quaternion.LookRotation(rb.velocity);
    }

    void Rotate()
    {
        float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    IEnumerator Scatter()
    {
        rb.AddForce(new Vector2(Random.Range(-359, 359), Random.Range(-359, 359)) * 0.01f, ForceMode2D.Force);
        yield return null;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == Tags.playerObject)
        {
            Debug.Log("Player Hit");
        }

        else if (col.tag == Tags.wall)
        {
            Destroy(gameObject);
        }
    }
}
*/