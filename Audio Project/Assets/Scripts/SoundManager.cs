using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager instance;

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

    void PlaySound()
    {

    }

    void PlaySound(Vector3 position)
    {
        // AK Sound engine call
        AkSoundEngine.PostEvent("Footstep", gameObject);
    }
}
