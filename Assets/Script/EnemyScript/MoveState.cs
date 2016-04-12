using UnityEngine;
using System.Collections;

public class MoveState : MonoBehaviour {

	public float velocity = 1f;
	public Transform sightStart;
	public Transform sightEnd;
	
	public bool colliding;
	public LayerMask detectWhat;
	
	void Start()
	{

	}


	void Update() 
	{
		
//		GetComponent<Rigidbody2D>().velocity = new Vector2 (velocity, GetComponent<Rigidbody2D>().velocity.y);
		colliding = Physics2D.Linecast (new Vector2(transform.position.x + 0.7f, transform.position.y - 0.5f), new Vector2(transform.position.x + 0.7f, transform.position.y + 0.5f));

		Debug.DrawLine (new Vector2(transform.position.x + 0.5f, transform.position.y - 0.5f), new Vector2(transform.position.x + 0.5f, transform.position.y + 0.5f), Color.red);

		Debug.Log (colliding);  
		if (colliding)
		{	
		 	transform.localScale = new Vector2 (transform.localScale.x * +1, transform.localScale.y);
			velocity *= -1;

		}

		Vector2 pos = transform.position;
		pos.x += velocity * Time.deltaTime;
		transform.position = pos;

	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.magenta;
		Gizmos.DrawLine (sightStart.position, sightEnd.position);
	}
}