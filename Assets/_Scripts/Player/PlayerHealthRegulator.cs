﻿using UnityEngine;
using System.Collections;

public class PlayerHealthRegulator : MonoBehaviour
{

    HealthItem healthItem;

    void Awake()
    {
        GlobalVars.playerHealth = 100;
        healthItem = GameObject.FindGameObjectWithTag(Tags.HealthPickup).GetComponent<HealthItem>();
        healthItem.Pickup += FullHeal;
    }

    void FixedUpdate()
    {
        
        if (GlobalVars.playerHealth <= 0)
        {
            Destroy(gameObject);
        }

    }
    void FullHeal()
    {
        GlobalVars.playerHealth = 100;
    }
}
