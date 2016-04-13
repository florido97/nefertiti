using UnityEngine;
using System.Collections;
using System;

public class PlayerInteraction : MonoBehaviour
{
    //make a delegate to determine what a interaction shouls do
    public delegate void InteractionEventHandaler();
    public InteractionEventHandaler Door;
    public InteractionEventHandaler Floor;
    public InteractionEventHandaler TrapDoor;
    public InteractionEventHandaler NextLevel;

    //when this object hits another 2D collider
    void OnTriggerStay2D(Collider2D coll)
    {
        //checks if the hit colider is the Lever
        if (coll.gameObject.tag == Tags.Lever)
        {
            //only activate the function once the player presses the Interact button
            if (Input.GetButtonDown("Interact"))
            {
                Door();
                coll.gameObject.GetComponent<Renderer>().material.color = Color.blue;//temp
            }
        }

        //checks if the hit colider is the WallLever
        if (coll.gameObject.tag == Tags.WallLever)
        {
            //only activate the function once the player presses the Interact button
            if (Input.GetButtonDown("Interact"))
            {
                coll.gameObject.GetComponent<Renderer>().material.color = Color.blue;//temp
                Floor();
            }
        }

        //checks if the hit colider is the PresurePlate
        if (coll.gameObject.tag == Tags.PresurePlate)
        {
            TrapDoor();
        }

        //checks if the hit colider is the  NextLevelWall
        if (coll.gameObject.tag == Tags.NextLevelWall)
        {
            NextLevel();
        }
    }
}