using UnityEngine;
using System.Collections;

public class FallFloor : MonoBehaviour
{
    //the players playerInteraction script
    PlayerInteraction playerInteraction;

    void Start()
    {
        //gets the playerInteraction script and adds the trapdoor function to the delecate
        playerInteraction = GameObject.FindGameObjectWithTag(Tags.PlayerObject).GetComponent<PlayerInteraction>();
        playerInteraction.TrapDoor += TrapDoor;
    }

    //a function to disable the trapdoor whenever the player hits it
    void TrapDoor()
    {
        gameObject.SetActive(false);    
    }
}
