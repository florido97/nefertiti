using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    //The prefab for the bullet this script shoots
    [SerializeField]
    GameObject bullet;

    //the speed of the bullet this script shoots
    [SerializeField]
    int speed = 100;

    //the direction wich the bullet has to go
    Vector2 direction;

    //The update sets the direction and detects input
    void Update () {

        //Setting the direction based on the players second thumbstick
        direction = new Vector2(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"));

        //Checking if the player presses the shoot button
        if (Input.GetButtonDown("shoot"))
        {
            Shoot();
        }
	}

    //The funciton that shoots a bullet based on the players aiming direction
    void Shoot()
    {
        //Tests if the direction is not zero, wich means the player is not aiming
        if (direction != new Vector2(0,0))
        {
            //Instantiate a bullet from the prefab, on top of the players position
            GameObject shotBullet = Instantiate(bullet, gameObject.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;

            //Moves the bullet at a set speed towards the direction
            shotBullet.GetComponent<Rigidbody2D>().AddForce(direction.normalized * speed, ForceMode2D.Force);
        
        }
    }
}
