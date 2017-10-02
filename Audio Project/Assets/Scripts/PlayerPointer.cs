using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPointer : MonoBehaviour {

    [SerializeField]
    private LayerMask layerMask;
    [SerializeField]
    private float distance = 2f;
    private IInteractable target = null;
    public IInteractable Target { get { return target; } }

    private Transform camera;


	// Use this for initialization
	void Start () {
        camera = Camera.main.gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
        CheckRaycast();	
	}

    void CheckRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.position, camera.forward, out hit , distance, layerMask))
        {
            //set target as object hit
            target = hit.collider.gameObject.GetComponent<IInteractable>();
            GameManager.instance.uiControl.DisplayInteractIcon(true);
        }
        else
        {
            target = null;
            GameManager.instance.uiControl.DisplayInteractIcon(false);
        }
       
    }
}
