using UnityEngine;
using System.Collections;

public class FallFloor : MonoBehaviour
{
    PlayerInteraction interAction;

    void Start()
    {
        interAction = GameObject.Find("Player").GetComponent<PlayerInteraction>();
        interAction.TrapDoor += TrapDoor;
    }

    void TrapDoor()
    {
        gameObject.SetActive(false);    
    }
}
