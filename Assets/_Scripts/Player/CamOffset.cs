using UnityEngine;
using System.Collections;

public class CamOffset : MonoBehaviour {

    Vector3 offset;

	void Update () {
	    offset = new Vector3(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"),0 );

        gameObject.transform.Translate(offset);
    }
}
