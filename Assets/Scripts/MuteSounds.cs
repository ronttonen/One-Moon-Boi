using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System.IO;
using UnityEngine.UI;

public class MuteSounds : MonoBehaviour {

    public Sprite mute;
    public Sprite unmute;

	public void Mute()
    {
        string key = "muted";
        if(PlayerPrefs.GetInt(key) == 0)
        {
            gameObject.GetComponent<Image>().sprite = unmute;
            AudioListener.pause = true;
            PlayerPrefs.SetInt(key, 1);
            
        } else
        {
            gameObject.GetComponent<Image>().sprite = mute;
            AudioListener.pause = false;
            PlayerPrefs.SetInt(key, 0);
        }
    }
}
