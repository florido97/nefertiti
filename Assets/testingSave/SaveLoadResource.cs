using UnityEngine;
using System.Collections;

public class SaveLoadResource : MonoBehaviour 
{
	public int gold;

	public void SaveResource()
	{
		PlayerPrefs.SetInt ("gold", gold);
		Debug.Log ("Resources Save");
	}

	public void LoadResource()
	{
		if (PlayerPrefs.HasKey ("gold")) 
		{	
			gold = PlayerPrefs.GetInt("gold");
			Debug.Log ("Resources Loaded");
		}
	}
}
