using UnityEngine;
using System.Collections;

public class FallFloor : MonoBehaviour
{
    Interaction interAction;
    private BoxCollider2D myHitBox;

    void Start()
    {
        myHitBox = GetComponent<BoxCollider2D>();
        interAction = GameObject.Find("Player").GetComponent<Interaction>();
        interAction.PresurePlate += PresurePlate;
    }

    void PresurePlate()
    {
        myHitBox.enabled = !myHitBox.enabled;
    }
}
