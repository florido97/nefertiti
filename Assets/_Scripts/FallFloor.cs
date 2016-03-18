using UnityEngine;
using System.Collections;

public class FallFloor : MonoBehaviour
{
    Interaction interAction;

    void Start()
    {
        interAction = GameObject.Find("Player").GetComponent<Interaction>();
        interAction.TrapDoor += TrapDoor;
    }

    void TrapDoor()
    {
        gameObject.SetActive(false);
    }
}
