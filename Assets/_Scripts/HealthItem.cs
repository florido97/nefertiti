using UnityEngine;
using System.Collections;

public class HealthItem : MonoBehaviour
{
    //make a delegate that determines what the pickup does
    public delegate void PlayerHealthEventHandler();
    public PlayerHealthEventHandler Pickup;

    //when this object hits a 2D collider
    void OnTriggerStay2D(Collider2D coll)
    {
        //check is the hit object is the player
        if (coll.gameObject.tag == Tags.PlayerObject)
        {
            //Does what the delegate does, and then destroy the object
            Pickup();
            Destroy(gameObject);
        }
    }
}
