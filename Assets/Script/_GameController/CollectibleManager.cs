using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollectibleManager : MonoBehaviour 
{
	[SerializeField]	private int collectibleToAdd,relicsToAdd;
	[SerializeField]	private int collectible,relics;


	[SerializeField] 	private Text text01/*,text02*/;
	[SerializeField] 	private Text text02;

	
	
	void Start ()
	{
		collectible = 0;
		relics = 0;

	}
	
	void Update ()
	{


	}
	
	public void addCollectible (int collectibleToAdd)
	{
		collectible += collectibleToAdd;
		text01.text = "" + collectible;
	}
	public void addRelic (int relicsToAdd)
	{
		relics += relicsToAdd;
		text02.text = "" + relics;
	}
}