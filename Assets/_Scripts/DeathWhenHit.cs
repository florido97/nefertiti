using UnityEngine;
using System.Collections;

public class DeathWhenHit : MonoBehaviour 
{

<<<<<<< HEAD
	void OnCollisionEnter2D(Collision2D col)
=======
    void OnCollisionEnter2D(Collision2D col)
>>>>>>> origin/master
    {
        if (col.gameObject.tag == "PlayerObject")
        {
            Application.Quit();
        }
<<<<<<< HEAD
		Debug.Log(col.gameObject.tag);
=======
        Debug.Log(col.gameObject.tag);
>>>>>>> origin/master
    }
}
