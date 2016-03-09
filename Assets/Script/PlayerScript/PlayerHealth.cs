using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public float maxHealth = 100f;
	public float currentHealth = 0f;
	public GameObject healthBar;
	
	void Start () 
	{
		currentHealth = maxHealth;
	}
	
	void Update () 
	{
		
	}

	void DecreaseHealth()
	{
		currentHealth -= 15f;
		float calc_Health = currentHealth / maxHealth;
		SetHealthBar (calc_Health);
	}
	
	void IncreaseHealth()
	{
		currentHealth += 10f;
		float calc_Health = currentHealth / maxHealth;
		SetHealthBar (calc_Health);
	}
	
	public void SetHealthBar(float myHealth)
	{
		healthBar.transform.localScale = new Vector3 (myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z); 
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") // tag must be renamed to itemTagName (Moet in een andere script)
		{
			IncreaseHealth();
		}

		if (other.gameObject.tag == "enemy") // tag must be renamed to itemTagName (Moet in een andere script)
		{
			DecreaseHealth();
		}
		
		if(currentHealth <= 0)
		{
			Destroy(this.gameObject);
//			Application.LoadLevel("GameOverScene");
		}
	}
}
