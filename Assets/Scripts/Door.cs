using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
    Interactie interActie;
    // Use this for initialization
    void Awake()
    {
        interActie = GameObject.Find("Player").GetComponent<Interactie>();
        interActie.StartTimer += DoorTimer;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void DoorTimer(int time)
    {
        Debug.Log("derp " + time + this.name);
        this.gameObject.GetComponent<Renderer>().material.color = new Color(21, 10, 38, 1);
    }
}
