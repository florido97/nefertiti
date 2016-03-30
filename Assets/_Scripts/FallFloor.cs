using UnityEngine;
using System.Collections;

public class FallFloor : MonoBehaviour
{
    PlayerInteraction playerInteraction;

    void Start()
    {
        playerInteraction = GameObject.Find("Player").GetComponent<PlayerInteraction>();
        playerInteraction.TrapDoor += TrapDoor;
    }

    void TrapDoor()
    {
        gameObject.SetActive(false);    
    }
}
