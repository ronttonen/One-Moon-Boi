using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GetHighScore : MonoBehaviour {

    


	// Use this for initialization
	void Start () {
        int score = PlayerPrefs.GetInt("highscore");
        
        gameObject.GetComponent<Text>().text = "Highscore: " + score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
