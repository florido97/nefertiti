using UnityEngine;
using System.Collections;

public class MenuCamControl : MonoBehaviour 
{

	[SerializeField] private Transform currentMount; 
	[SerializeField] private float SpeedFactor = 0.1f; 

		
	void Update () 
	{
		// moves the camera from it's current position to (given) public Mount
		transform.position = Vector3.Lerp (transform.position, currentMount.position, SpeedFactor );
	}

	public void setmount (Transform newMount)
	{
		currentMount = newMount;
	}

	public void QuitGame()
	{
		Application.Quit (); 
	}
}
