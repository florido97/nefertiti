using UnityEngine;
using System.Collections;
using System;

public class PlayerInteraction : MonoBehaviour
{
    public delegate void InteractionEventHandaler();
    public InteractionEventHandaler Door;
    public InteractionEventHandaler Floor;
    public InteractionEventHandaler TrapDoor;
    public InteractionEventHandaler NextLevel;

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == Tags.Lever)
        {
            if (Input.GetButtonDown("Interact"))
            {
                Door();
                coll.gameObject.GetComponent<Renderer>().material.color = Color.blue;//temp
            }
        }
        if (coll.gameObject.tag == Tags.WallLever)
        {
            if (Input.GetButtonDown("Interact"))
            {
                coll.gameObject.GetComponent<Renderer>().material.color = Color.blue;//temp
                Floor();
            }
        }
        if (coll.gameObject.tag == Tags.PresurePlate)
        {
            TrapDoor();
        }
        if (coll.gameObject.tag == Tags.NextLevelWall)
        {
            NextLevel();
        }
    }
}