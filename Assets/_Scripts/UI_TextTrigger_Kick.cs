using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_TextTrigger : MonoBehaviour {
    [SerializeField]
    private bool trigger01;
    [SerializeField]
    private Image tut01;
    [SerializeField]
    private Image text01;

    [SerializeField]
    private bool trigger02;
    [SerializeField]
    private Image tut02;
    [SerializeField]
    private Image text02;

    [SerializeField]
    private bool trigger03;
    [SerializeField]
    private Image tut03;
    [SerializeField]
    private Image text03;

    [SerializeField]
    private bool trigger04;
    [SerializeField]
    private Image tut04;
    [SerializeField]
    private Image text04;

    [SerializeField]
    private bool trigger05;
    [SerializeField]
    private Image tut05;
    [SerializeField]
    private Image text05;


    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == Tags.Tut01)
        {
            trigger01 = true;
            Debug.Log("Trigger 1 hit! " + trigger01);
        }

        if (coll.gameObject.tag == Tags.Tut02)
        {
            trigger02 = true;
            Debug.Log("Trigger 2 hit! " + trigger02);
        }

        if (coll.gameObject.tag == Tags.Tut03)
        {
            trigger03 = true;
            Debug.Log("Trigger 3 hit! " + trigger03);
        }

        if (coll.gameObject.tag == Tags.Tut04)
        {
            trigger04 = true;
            Debug.Log("Trigger 4 hit! " + trigger04);
        }

        if (coll.gameObject.tag == Tags.Tut05)
        {
            trigger05 = true;
            Debug.Log("Trigger 5 hit! " + trigger05);
        }

    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == Tags.Tut01)
        {
            trigger01 = false;
        }

        if (coll.gameObject.tag == Tags.Tut02)
        {
            trigger02 = false;
        }

        if (coll.gameObject.tag == Tags.Tut03)
        {
            trigger03 = false;
        }

        if (coll.gameObject.tag == Tags.Tut04)
        {
            trigger04 = false;
        }

        if (coll.gameObject.tag == Tags.Tut05)
        {
            trigger05 = false;
        }

    }

    // Update is called once per frame
    void Update () {

        if (trigger01 == true)
        {
            tut01.enabled = true;
            text01.enabled = true;

            trigger02 = false;
            trigger03 = false;
            trigger04 = false;
            trigger05 = false;
        }
        if (trigger01 == false)
        {
            tut01.enabled = false;
            text01.enabled = false;
        }

        //-----------------------------------

        if (trigger02 == true)
        {
            tut02.enabled = true;
            text02.enabled = true;

            trigger01 = false;
            trigger03 = false;
            trigger04 = false;
            trigger05 = false;
        }
        if (trigger02 == false)
        {
            tut02.enabled = false;
            text02.enabled = false;
        }

        //-----------------------------------

        if (trigger03 == true)
        {
            tut03.enabled = true;
            text03.enabled = true;

            trigger01 = false;
            trigger02 = false;
            trigger04 = false;
            trigger05 = false;
        }
        if (trigger03 == false)
        {
            tut03.enabled = false;
            text03.enabled = false;
        }
        //-----------------------------------

        if (trigger04 == true)
        {
            tut04.enabled = true;
            text04.enabled = true;

            trigger01 = false;
            trigger02 = false;
            trigger03 = false;
            trigger05 = false;
        }
        if (trigger04 == false)
        {
            tut04.enabled = false;
            text04.enabled = false;
        }

        //-----------------------------------

        if (trigger05 == true)
        {
            tut05.enabled = true;
            text05.enabled = true;

            trigger01 = false;
            trigger02 = false;
            trigger03 = false;
            trigger04 = false;
        }
        if (trigger05 == false)
        {
            tut05.enabled = false;
            text05.enabled = false;
        }

    }
}