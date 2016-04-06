
using UnityEngine;
using System.Collections;
using System;

public class Interaction : MonoBehaviour
{
    public delegate void InteractionEventHandaler();
    public InteractionEventHandaler Door;
    public InteractionEventHandaler Floor;
    public InteractionEventHandaler PresurePlate;

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == Tags.Lever)
        {
            if (Input.GetKeyDown("space"))
            {
                Door();
            }
        }

        if (coll.gameObject.tag == Tags.WallLever)
        {
            if (Input.GetKeyDown("space"))
            {
                Floor();
            }
        }

        if (coll.gameObject.tag == Tags.PresurePlate)
        {
            PresurePlate();
        }
    }
}