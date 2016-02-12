using UnityEngine;
using System.Collections;

public class Interactie : MonoBehaviour
{

    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == Tags.Lever)
        {
            if (Input.GetKeyDown("space"))
            {
                coll.gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 0, 0);
            }
                            
        }

    }

}