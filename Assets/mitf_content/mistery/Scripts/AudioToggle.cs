using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioToggle : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isOn;
    void Start()
    {
        isOn = true;
    }

   public void OnOffSounds()
    {
        if(!isOn)
        {
            AudioListener.volume = 1f;
            isOn = true;
        }
        else if (isOn)
        {
            AudioListener.volume = 0f;
            isOn = false;
        }
    }
}
