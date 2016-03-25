using UnityEngine;
using System.Collections;

public class FallFloor : MonoBehaviour
{
<<<<<<< HEAD
    PlayerInteraction interAction;

    void Start()
    {
        interAction = GameObject.Find("Player").GetComponent<PlayerInteraction>();
        interAction.TrapDoor += TrapDoor;
=======
    PlayerInteraction playerInteraction;

    void Start()
    {
        playerInteraction = GameObject.Find("Player").GetComponent<PlayerInteraction>();
        playerInteraction.TrapDoor += TrapDoor;
>>>>>>> f420e9374b74cf17c0eb6c6bc451ad4c0dda7971
    }

    void TrapDoor()
    {
        gameObject.SetActive(false);    
    }
}
