using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour {

    Rigidbody2D rb;
    int timeoutTime = 3;

	void Start () {
        rb = GetComponent<Rigidbody2D>();

        Destroy(gameObject, timeoutTime) ;
    }

    void Update()
    {
        float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Test");
        if (col.gameObject.tag != "PlayerObject")
        {
            rb.velocity = Vector3.zero;
            Destroy(gameObject, 0.25f);
        }
    }
}
