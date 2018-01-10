using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAppe : MonoBehaviour {

    public Sprite mute;
    public Sprite unmute;

	// Use this for initialization
	void Start () {
        string key = "muted";
        if (PlayerPrefs.GetInt(key) == 1)
        {
            gameObject.GetComponent<Image>().sprite = unmute;
            AudioListener.pause = true;
            PlayerPrefs.SetInt(key, 1);
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = mute;
            AudioListener.pause = false;
            PlayerPrefs.SetInt(key, 0);


        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
