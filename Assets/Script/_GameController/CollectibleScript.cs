using UnityEngine;
using System.Collections;

public class CollectibleScript : MonoBehaviour 
{
	[SerializeField] private int collectibleToAdd,relicsToAdd;
	CollectibleManager cm;
	// Use this for initialization
	void Start () 
	{
		cm = FindObjectOfType<CollectibleManager> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter2D(Collider2D  other) {
		if(other.transform.tag == "Player")
		{
			cm.addCollectible(collectibleToAdd);
			cm.addRelic(relicsToAdd);
			Destroy(this.gameObject);
			
		}
	}
}
