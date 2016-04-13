using UnityEngine;
using System.Collections;

public class WinGameSprite : MonoBehaviour {

    SpriteRenderer rend;
	void Start () {
        rend = GameObject.Find("WinSprite").GetComponent<SpriteRenderer>();
        rend.enabled = false;
	}

    void OnTriggerEnter2D()
    {
        rend.enabled = true;
    }
}
