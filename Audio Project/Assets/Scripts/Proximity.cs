using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proximity : MonoBehaviour {

    [SerializeField]
    private string textToDisplay = "Hello there player";

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OverlapWithPlayer();
        }
    }

    private void OverlapWithPlayer()
    {
        //TODO remove later
        // display text
        GameManager.instance.uiControl.DisplayText(textToDisplay);
    }

}
