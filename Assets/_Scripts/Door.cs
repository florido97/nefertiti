using UnityEngine;
using System.Collections;
using System;

public class Door : MonoBehaviour
{
    public Transform target;
    [SerializeField]
    private float speed = 10;
    [SerializeField]
    private float time = 50f;
    private bool doorIsUp = false;
    Interactie interActie;
    private Vector2 initalPos;

    

    void Awake()
    {
        interActie = GameObject.Find("Player").GetComponent<Interactie>();
        interActie.StartTimer += DoorTimer;
        initalPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        float step = speed * Time.deltaTime;
        if (doorIsUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, initalPos, step);
        }

        time -= Time.deltaTime;
        if (time <= 0)
        {
            doorIsUp = false;
            time = 10;
        }
    }

    void DoorTimer()
    {

        doorIsUp = true;
        this.gameObject.GetComponent<Renderer>().material.color = new Color(21, 10, 38, 1);
    }
}
