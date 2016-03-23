using UnityEngine;
using System.Collections;

public class DeathWhenHit : MonoBehaviour 
{

    void OnCollisionEnter2D(Collider2D col)
    {
        if (col.tag == "PlayerObject")
        {
            Application.Quit();
        }
        Debug.Log(col.tag);
    }
}