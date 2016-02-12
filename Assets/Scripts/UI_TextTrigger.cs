using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_TextTrigger : MonoBehaviour {
    [SerializeField] private bool nearSign;
    [SerializeField] private Text sampleText;

	// Update is called once per frame
	void Update () {
	    if(nearSign == true)
        {
            sampleText.enabled = true;
        }
        else
        {
            sampleText.enabled = false;
        }
	}
}