using UnityEngine;
using System.Collections;

public class DeathWhenHit : MonoBehaviour 
{

	void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "PlayerObject")
        {
            Application.Quit();
        }
		Debug.Log(col.gameObject.tag);
    }
}
