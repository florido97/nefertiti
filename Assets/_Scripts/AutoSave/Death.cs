using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

    void Start()
    {
        //Sets the standard save point
        GlobalVars.CurrentSavePoint = new Vector2(-60.3f, 17);
    }
    
    //When this object hits a 2D colider
    void OnCollisionEnter2D(Collision2D col)
    {
        //Checks if the object hit is the player
        if (col.gameObject.tag == Tags.PlayerObject)
        {
            //Returns the player to the last savepoint 
            col.gameObject.transform.position = GlobalVars.CurrentSavePoint;
        }
    }
}
