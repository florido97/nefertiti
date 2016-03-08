
using UnityEngine;
using System.Collections;
using System;

public class Interactie : MonoBehaviour
{
    public delegate void TimerStarter(int time);
    public TimerStarter StartTimer;

    /*private void DoorTimer(int time)
    {
        Debug.Log("derp" + time);
    }*/

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == Tags.Lever)
        {
            if (Input.GetKeyDown("space"))
            {
                coll.gameObject.GetComponent<Renderer>().material.color = new Color(21, 10, 38, 1);
                Destroy(GameObject.Find("delete"));
            }

        }
        if (coll.gameObject.tag == Tags.Lever)
        {
            if (Input.GetKeyDown("space"))
            {
                StartTimer(10);
                coll.gameObject.GetComponent<Renderer>().material.color = new Color(21, 10, 38, 1);
                Destroy(GameObject.Find("delete"));
            }
        }
    }
}