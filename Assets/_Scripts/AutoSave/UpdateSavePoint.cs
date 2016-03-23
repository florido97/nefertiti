using UnityEngine;
using System.Collections;

public class UpdateSavePoint : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == Tags.playerObject)
        {
            GlobalVars.CurrentSavePoint = gameObject.transform.position;
            Destroy(gameObject);
        }
    }
}
