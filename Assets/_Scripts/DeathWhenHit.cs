using UnityEngine;
using System.Collections;

public class DeathWhenHit : MonoBehaviour 
{

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == Tags.PlayerObject)
        {
            Application.Quit();
        }
    }
}
