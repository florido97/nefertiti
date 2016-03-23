using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor (typeof(SaveLoadResource))]

public class SaveLoadResourcesEditor : Editor {

	public override void OnInspectorGUI() 
	{
		SaveLoadResource saveLoadResources = (SaveLoadResource)target;
		
		DrawDefaultInspector();
		
		GUILayout.BeginHorizontal();
		if  (GUILayout.Button("Save Game"))
		{
			saveLoadResources.SaveResource();
		}
		if  (GUILayout.Button("Load Game"))
		{
			saveLoadResources.LoadResource();
		}
		GUILayout.EndHorizontal();
	}
}