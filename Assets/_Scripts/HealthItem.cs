using UnityEngine;
using System.Collections;

public class HealthItem : MonoBehaviour
{
    public delegate void PlayerHealthEventHandler();
    public PlayerHealthEventHandler Pickup;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == Tags.PlayerObject)
        {
            Pickup();
            Destroy(gameObject);
        }
    }
}
