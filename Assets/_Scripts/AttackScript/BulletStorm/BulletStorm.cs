using UnityEngine;
using System.Collections;

public class BulletStorm : MonoBehaviour {

    [SerializeField]
    GameObject bullet;

    public void Attack(Vector3 bulletSpawnpoint, int bulletAmount)
    {
        for (int i = 0; i < bulletAmount; i++)
        {
            Instantiate(bullet, bulletSpawnpoint, Quaternion.identity);
        }
    }
}
