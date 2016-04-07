using UnityEngine;
using System.Collections;

public class EnemyFollow : MonoBehaviour {

	[SerializeField] private Transform player;
	[SerializeField] private float minDistance = 4.0f;
	private float range;
	[SerializeField] private float moveSpeed = 3;

	void Start () 
	{
	
	}
	
	void Update ()
	{
//		Chase();
		// Werkt al correct 
		range = Vector2.Distance (transform.position, player.position);
		
		// range is smaller than MinDistance follow player
		if (range <= minDistance)
		{	
			transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
		}
	}
	
	
	void OnDrawGizmos() {
		Gizmos.DrawWireSphere (transform.position, minDistance);
	}


	void Chase () 
	{
		// Uncomment the make the Enemy follow forever  

//		float movementDistance = moveSpeed * Time.deltaTime;
//		transform.position = Vector3.MoveTowards(transform.position, player.position, movementDistance);
	}

}