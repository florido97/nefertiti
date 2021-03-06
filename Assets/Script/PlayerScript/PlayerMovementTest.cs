﻿using UnityEngine;
using System.Collections;

public class PlayerMovementTest : MonoBehaviour 
{
	public Rigidbody2D rb2D;
	private float moveSpeed = 12f;
	public float jumpPower = 150f;
	
	// Use this for initialization
	void Start () 
	{
		rb2D = GetComponent<Rigidbody2D> ();
	}


	void FixedUpdate () 
	{
		Movement ();
	}


	void Movement()
	{
		float x = Input.GetAxis("Horizontal");
		rb2D.velocity = new Vector2(x * moveSpeed,0 );

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.localScale = new Vector3 (3, transform.localScale.y, transform.localScale.z);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.localScale = new Vector3 (-3, transform.localScale.y, transform.localScale.z);
		}
	}
}