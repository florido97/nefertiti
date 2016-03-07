using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Boss1 : MonoBehaviour {

    private Vector2 bulletSpawnPoint;
    private BulletStorm bulletStorm;
    private BulletRain bulletRain;
    private int randomNumber;

    [SerializeField]
    private int loopTime = 1;

    [SerializeField]
    private int bulletAmount = 10;

    private GameObject attackStartTrigger;

	void Start () {
        bulletSpawnPoint = GameObject.Find(Tags.Bulletpoint).transform.position;
        bulletStorm = GetComponent<BulletStorm>();
        bulletRain = GetComponent<BulletRain>();

        attackStartTrigger = GameObject.Find(Tags.b0ssTrigger);

        startAttack();
	}
     
    public void startAttack()
    {
        StartCoroutine(Loop(loopTime));
    }
	
	IEnumerator Loop(float loopTime)
    {
        randomNumber = Random.Range(0, 2);

        if (randomNumber == 0)
        {
            bulletStorm.Attack(bulletSpawnPoint, bulletAmount);
        }

        else if (randomNumber == 1)
        {
            bulletRain.Attack(30, -30, 40, 10, bulletSpawnPoint);
        }

            yield return new WaitForSeconds(loopTime);
        StartCoroutine(Loop(loopTime));
    }
}
