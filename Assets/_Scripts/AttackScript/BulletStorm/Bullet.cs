using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    private GameObject player;
    private Rigidbody2D rb;

    [SerializeField]
    private float bulletSpeed = 10;

    void Start()
    {
        player = GameObject.Find(Tags.playerObject);
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Scatter());
    }

    void Update () {
        rb.AddForce(((player.transform.position - transform.position) * bulletSpeed), ForceMode2D.Force);
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
