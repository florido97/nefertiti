using UnityEngine;
using System.Collections;

public class FallFloor : MonoBehaviour
{
    PlayerInteraction playerInteraction;

    void Start()
    {
        playerInteraction = GameObject.FindGameObjectWithTag(Tags.PlayerObject).GetComponent<PlayerInteraction>();
        playerInteraction.TrapDoor += TrapDoor;
    }

    void TrapDoor()
    {
        gameObject.SetActive(false);    
    }
}
