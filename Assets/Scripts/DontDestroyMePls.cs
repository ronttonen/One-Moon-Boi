using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMePls : MonoBehaviour {

    private GameObject backgroundMusic;
    public GameObject backgroundMusicPrefab;

    // Use this for initialization
    void Start()
    {
        if(!GameObject.FindWithTag("BackgroundMusic"))
        {
            backgroundMusic = Instantiate(backgroundMusicPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
            backgroundMusic.GetComponent<AudioSource>().Play();
        }

        

        DontDestroyOnLoad(backgroundMusic);  
    }

    
}
