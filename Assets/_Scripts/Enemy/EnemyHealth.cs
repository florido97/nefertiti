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
            //coll.gameObject.GetComponent<Renderer>().material.color = Color.blue;//temp
            
        }
    }
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Debug.Log("MOOOOO " + enemyHealth );
            Destroy(gameObject);
        }
    }
    
}
