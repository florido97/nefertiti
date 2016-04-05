using UnityEngine;
using System.Collections;

public class EnemyWalking : MonoBehaviour 
{
	
	[SerializeField] private float speed = 1f;
	[SerializeField] private Vector3 direction;

	
	void Start()
	{
		EnemyBehaviour ();
	}
	
	
	void FixedUpdate() 
	{
		transform.position += direction * speed * Time.deltaTime;
	}

	void EnemyBehaviour()
	{
		direction = (new Vector3( 1.0f, 0.0f, 0.0f));
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == Tags.TurnAround) 
		{	

			transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);


			direction = -direction;
		}
	}

}