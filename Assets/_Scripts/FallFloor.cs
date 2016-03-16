using UnityEngine;
using System.Collections;

public class FallFloor : MonoBehaviour
{
    Interaction interAction;

    void Start()
    {
        interAction = GameObject.Find("Player").GetComponent<Interaction>();
        interAction.PresurePlate += PresurePlate;
    }

    void PresurePlate()
    {
        gameObject.SetActive(false);
    }
}
