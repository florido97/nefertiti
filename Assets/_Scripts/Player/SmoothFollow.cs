using UnityEngine;
using System.Collections;

public class SmoothFollow : MonoBehaviour {

	[SerializeField] private GameObject _target;
	private float _offset = 4f;

	void FixedUpdate () 
	{

		float x = Input.GetAxis ("Horizontal2");
		float y = Input.GetAxis ("Vertical2");

		float offsetX = _target.transform.position.x + x * _offset;
		float offsetY = _target.transform.position.y + y * _offset;

		transform.position = Vector3.Lerp (transform.position, new Vector3 (offsetX, offsetY, transform.position.z), 0.09f);
	}
}