using UnityEngine;
using System.Collections;

public class UpdateSavePoint : MonoBehaviour {

    //When this object hits a 2D colider
    void OnTriggerEnter2D(Collider2D col)
    {
        //check if the hit object is the player
        if (col.gameObject.tag == Tags.PlayerObject)
        {
            //Sets the CurrentSavePoint to this objects position
            GlobalVars.CurrentSavePoint = gameObject.transform.position;

            //Destroys this gameobject so it wont set the savepoint back when backtracking
            Destroy(gameObject);
        }
    }
}
