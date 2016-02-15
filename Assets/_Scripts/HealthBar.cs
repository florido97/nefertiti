using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

    GameObject overHealth;

	void Start () {
        overHealth = GameObject.Find(Tags.overHealth);
	}
	
	void Update () {
        Debug.Log(GlobalVars.playerHealth);
        GlobalVars.playerHealth -= 1;
	}
}
