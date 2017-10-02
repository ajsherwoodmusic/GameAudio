using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IInteractable {

    [SerializeField]
    private string textToDisplay;


    [SerializeField]
    private AudioClip audioClip;
    [SerializeField]
    private bool hasClue;
	// Use this for initialization
	void Start () {
		
	}

    public void Interact()
    {

        // TODO Remove later
        GameManager.instance.uiControl.DisplayText(textToDisplay);
        //PlayAudio();

        //Only if this NPC has a clue
        if (hasClue)
        {
            hasClue = false;
            GameManager.instance.ClueFound();
        }

    }


    //TODO remove later for WWise
    private void PlayAudio()
    {
        AudioSource source = GetComponent<AudioSource>();
        source.PlayOneShot(audioClip);
    }

}
