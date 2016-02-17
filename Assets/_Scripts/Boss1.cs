using UnityEngine;
using System.Collections;

public class Boss1 : MonoBehaviour {

    private Vector2 bulletSpawnPoint;
    private BulletStorm bulletStorm;
    private int loopTime = 5;

    [SerializeField]
    private int bulletAmount = 10;

	void Start () {
        bulletSpawnPoint = GameObject.Find(Tags.Bulletpoint).transform.position;
        bulletStorm = GetComponent<BulletStorm>();
        StartCoroutine(Loop(loopTime));
	}
	
	IEnumerator Loop(float loopTime)
    {
        bulletStorm.Attack(bulletSpawnPoint, bulletAmount);
        yield return new WaitForSeconds(loopTime);
        StartCoroutine(Loop(loopTime));
    }
}
