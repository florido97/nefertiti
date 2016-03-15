using UnityEngine;
using System.Collections;

public class CamOffset : MonoBehaviour {

    Vector3 offset;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    offset = new Vector3(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"),0 );
        Debug.Log(offset);

        gameObject.transform.Translate(offset);
    }
}
