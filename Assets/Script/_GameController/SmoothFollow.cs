using UnityEngine;
using System.Collections;

public class SmoothFollow : MonoBehaviour {

	[SerializeField] private GameObject _target;
	private float _offset = 4f;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");

		float offsetX = _target.transform.position.x + x * _offset;
		float offsetY = _target.transform.position.y + y * _offset;

		transform.position = Vector3.Lerp (transform.position, new Vector3 (offsetX, offsetY, transform.position.z), 0.09f);

	}
}
