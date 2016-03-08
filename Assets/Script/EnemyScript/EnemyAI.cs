using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour{
	public Transform target;
	private float minDistance = 4.0f;
	private float range;
	public float moveSpeed = 3;


	void Start () {

	}

	void Update ()
	{
		Chase();
		// Werkt al correct 
		range = Vector2.Distance (transform.position, target.position);

		// range is smaller than MinDistance follow player
		if (range <= minDistance)
		{	
			transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
		}
	}
	
	void Chase () {
		float movementDistance = moveSpeed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, movementDistance);
	}

	void OnDrawGizmos() {
		Gizmos.DrawWireSphere (transform.position, minDistance);
	}
}