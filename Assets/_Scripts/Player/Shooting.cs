using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {
    [SerializeField]
    GameObject bullet;

    [SerializeField]
    int speed = 100;

    Vector2 offset;

    void Update () {

        offset = new Vector2(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"));

        if (Input.GetButtonDown("shoot"))
        {
            Shoot();
        }
	}

    void Shoot()
    {
        if (offset != new Vector2(0,0))
        {
            GlobalVars.playerHealth -= 10;
            GameObject shotBullet = Instantiate(bullet, gameObject.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            shotBullet.GetComponent<Rigidbody2D>().AddForce(offset.normalized * speed, ForceMode2D.Force);
        
        }
    }
}
