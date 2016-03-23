using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

    void Start()
    {
        GlobalVars.CurrentSavePoint = new Vector2(-60.3f, 17);
    }
    

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == Tags.playerObject)
        {
            col.gameObject.transform.position = GlobalVars.CurrentSavePoint;
        }
    }
}
