using UnityEngine;
using System.Collections;

public class SmoothFollow : MonoBehaviour
{

    [SerializeField]
    private GameObject _target;
    private float _offset = 4f;

<<<<<<< HEAD
	void FixedUpdate () 
	{
=======

    // Use this for initialization
    void Start()
    {

    }
>>>>>>> b20b94420e0d568f033d0a35fd129021fb9844e6

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_target != null)
        {
            float x = Input.GetAxis("Horizontal2");
            float y = Input.GetAxis("Vertical2");

            float offsetX = _target.transform.position.x + x * _offset;
            float offsetY = _target.transform.position.y + y * _offset;

<<<<<<< HEAD
		transform.position = Vector3.Lerp (transform.position, new Vector3 (offsetX, offsetY, transform.position.z), 0.09f);
	}
}
=======
            transform.position = Vector3.Lerp(transform.position, new Vector3(offsetX, offsetY, transform.position.z), 0.09f);
        }
    }
}
>>>>>>> b20b94420e0d568f033d0a35fd129021fb9844e6
