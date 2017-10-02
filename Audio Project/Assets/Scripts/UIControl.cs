using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour {

    [SerializeField]
    private Text displayText;
    [SerializeField]
    private Image interactIcon;

    private float time = 0f;
    private float textDisplayTime = 3f;

    private bool delayActivated = false;

    private void Start()
    {
        DisplayInteractIcon(false);
    }

    public void DisplayText(string text)
    {
        displayText.text +=  text + "\n";
        time = 0;
        if (!delayActivated)
        {
            
            delayActivated = true;
            StartCoroutine(DelayRemoveText());
        }
    }

    IEnumerator DelayRemoveText()
    {
        while (time < textDisplayTime)
        {
            time += Time.deltaTime;
            //Debug.Log("Time remaining = " + (textDisplayTime - time));
            yield return null;
        }

        delayActivated = false;
        displayText.text = "";
    }

    public void DisplayInteractIcon(bool enabled)
    {
        interactIcon.enabled = enabled;
    }
}
