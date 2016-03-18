
using UnityEngine;
using System.Collections;
using System;

public class Interaction : MonoBehaviour
{
<<<<<<< HEAD
    public delegate void InteractionEventHandler();
    public InteractionEventHandler Door;
    public InteractionEventHandler Floor;
    public InteractionEventHandler PresurePlate;
=======
    public delegate void InteractionEventHandaler();
    public InteractionEventHandaler Door;
    public InteractionEventHandaler Floor;
    public InteractionEventHandaler TrapDoor;
    public InteractionEventHandaler NextLevel;
>>>>>>> fe41e004a08523363d1359610e37e54719e376a1

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
                coll.gameObject.GetComponent<Renderer>().material.color = Color.blue;
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