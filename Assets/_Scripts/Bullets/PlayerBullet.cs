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
}
