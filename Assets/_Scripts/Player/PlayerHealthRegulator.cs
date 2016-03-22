﻿using UnityEngine;
using System.Collections;

public class PlayerHealthRegulator : MonoBehaviour
{

    HealthItem healthItem;

    void Awake()
    {
        healthItem = GameObject.FindGameObjectWithTag(Tags.HealthPickup).GetComponent<HealthItem>();
        healthItem.Pickup += FullHeal;
    }

    void FixedUpdate()
    {
        Debug.Log(GlobalVars.playerHealth);
        //GlobalVars.playerHealth -= 1;
        if (GlobalVars.playerHealth <= 0)
        {
            Debug.Log("DEATH HAS ITS GRIP ON YOU");
            Destroy(gameObject);
        }
    }
    void FullHeal()
    {
        GlobalVars.playerHealth = 100;
    }
}