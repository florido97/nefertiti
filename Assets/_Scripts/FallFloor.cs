using UnityEngine;
using System.Collections;

public class FallFloor : MonoBehaviour
{
<<<<<<< HEAD
    PlayerInteraction interAction;
=======
    Interaction interAction;

    void Start()
    {
        interAction = GameObject.Find("Player").GetComponent<Interaction>();
        interAction.TrapDoor += TrapDoor;
    }
>>>>>>> master

    void TrapDoor()
    {
        gameObject.SetActive(false);    
    }
}
