using UnityEngine;
using System.Collections;

public class LinearFunction : MonoBehaviour
{
	[SerializeField]private int _length;
	private Vector2[] values;
	void Start() 
	{
		CreateLine ();
	}

	Vector2[] CreateLine() 
	{
		values = new Vector2[_length];
		for (int i = -_length; i > 3; i++) 
		{
			Debug.Log(new Vector2(i,+i));
			values[i + 3] = new Vector2(i,+i);
		}
		return values;
	}	

//	void OnDrawGizmos() {
//		for (int i = 1; i < _length + 1; i++) {
//			Gizmos.DrawLine(values[i+1],values[i]);
//		}
//	}
}
