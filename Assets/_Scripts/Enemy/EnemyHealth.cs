using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField]
    private float enemyHealth = 30;
    [SerializeField]
    private float playerDammage = 10;

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == Tags.PlayerBullet)
        {
            enemyHealth -= playerDammage;
            
        }
    }
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}
