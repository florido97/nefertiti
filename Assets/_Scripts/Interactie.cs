using UnityEngine;
using System.Collections;

public class Interactie : MonoBehaviour
{

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == Tags.Lever)
        {
            if (Input.GetKeyDown("space"))
            {
                coll.gameObject.GetComponent<Renderer>().material.color = new Color(21, 10, 38, 1);
                Destroy(GameObject.Find("delete"));
            }
                            
        }

    }

}