using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public UIControl uiControl;

    private Player player;

    //TODO update to animate 
    [SerializeField]
    private GameObject pathBlocker;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
    }

    // Use this for initialization
    void Start () {

        uiControl = FindObjectOfType<UIControl>();
        player = FindObjectOfType<Player>();
	}

    public void ClueFound()
    {
        player.ClueFound();
        if (player.CluesFound >= 3)
        {
            ClearPath();
        }
    }

    private void ClearPath()
    {
        pathBlocker.SetActive(false);
        uiControl.DisplayText("All clues found. Gate now open");
    }
}
