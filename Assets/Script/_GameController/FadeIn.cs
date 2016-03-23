using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour 
{
	public Image blackImage;

	public float FadeoutTime;
	public float fadeSpeed = 1.5f;
	private bool fadeIn = false;  

	void  Start ()
	{
		Fading ();
	}


	void  Update ()
	{
		
	}

	public void Fading()
	{
		fadeIn = true;
		Debug.Log("Fading In");

		if(fadeIn){
			blackImage.color = Color.Lerp(blackImage.color, new Color(0,0,0,0), fadeSpeed * Time.deltaTime);

			if(blackImage.color.a >= 0.01)
			{
				fadeIn = false;
			}
		}
	}
}
