using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private int cluesFound = 0;
    public int CluesFound { get { return cluesFound; } }

    private PlayerPointer playerPointer;
	// Use this for initialization
	void Start () {
        playerPointer = FindObjectOfType<PlayerPointer>();
    }

    public void Interact()
    {
        IInteractable target = playerPointer.Target;
        if (target != null)
        {
            target.Interact();
        }
    }

    public void ClueFound()
    {        
        if (cluesFound < 3)
        {
            cluesFound++;
        }
    }
}
