using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_TextTrigger : MonoBehaviour {

    //kick

    [SerializeField]
    private bool trigger01;
    [SerializeField]
    private Image tut01;
    [SerializeField]
    private Text text01;

    [SerializeField]
    private bool trigger02;
    [SerializeField]
    private Image tut02;
    [SerializeField]
    private Text text02;

    [SerializeField]
    private bool trigger03;
    [SerializeField]
    private Image tut03;
    [SerializeField]
    private Text text03;

    [SerializeField]
    private bool trigger04;
    [SerializeField]
    private Image tut04;
    [SerializeField]
    private Text text04;

    [SerializeField]
    private bool trigger05;
    [SerializeField]
    private Image tut05;
    [SerializeField]
    private Text text05;

    void Update () {
        if(trigger02 == false && trigger03 == false && trigger04 == false && trigger05 == false)
        {
            if (trigger01 == true)
            {
                tut01.enabled = true;
                text01.enabled = true;
            }
            if (trigger01 == false)
            {
                tut01.enabled = false;
                text01.enabled = false;
            }
        }

        //-----------------------------------
        if (trigger01 == false && trigger03 == false && trigger04 == false && trigger05 == false)
        {
            if (trigger02 == true)
            {
                tut02.enabled = true;
                text02.enabled = true;
            }
            if (trigger02 == false)
            {
                tut02.enabled = false;
                text02.enabled = false;
            }
        }
        //-----------------------------------
        if (trigger01 == false && trigger02 == false && trigger04 == false && trigger05 == false)
        {
            if (trigger03 == true)
            {
                tut03.enabled = true;
                text03.enabled = true;
            }
            if (trigger03 == false)
            {
                tut03.enabled = false;
                text03.enabled = false;
            }
        }
        //-----------------------------------
        if (trigger01 == false && trigger02 == false && trigger03 == false && trigger05 == false)
        {
            if (trigger04 == true)
            {
                tut04.enabled = true;
                text04.enabled = true;
            }
            if (trigger04 == false)
            {
                tut04.enabled = false;
                text04.enabled = false;
            }
        }
        //-----------------------------------
        if (trigger01 == false && trigger02 == false && trigger03 == false && trigger04 == false)
        {
            if (trigger05 == true)
            {
                tut05.enabled = true;
                text05.enabled = true;
            }
            if (trigger05 == false)
            {
                tut05.enabled = false;
                text05.enabled = false;
            }
        }
    }
}