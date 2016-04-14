using UnityEngine;
using System.Collections;

public class SceneLoader : MonoBehaviour 
{

    public int gameScene = 1;

    // optioneel code
    //	public void Change(int scene) 
    //	{
    //		Application.LoadLevel (scene);
    //	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Cam")
        {
            Application.LoadLevel(gameScene);
        }
    }

}
