using UnityEngine;
using System.Collections;

public class BulletRain : MonoBehaviour {

    [SerializeField]
    private GameObject bullet;

    public void Attack(int maxWidthtOffset, int minWidthtOffset, int heightOffset, int amount, Vector3 bulletSpawnpoint)
    {
        for (int i = 0; i < amount; i++)
        {
            Instantiate(bullet, new Vector3(bulletSpawnpoint.x + Random.Range(minWidthtOffset, maxWidthtOffset), bulletSpawnpoint.y + heightOffset), Quaternion.identity);
            
        }
    }
}
