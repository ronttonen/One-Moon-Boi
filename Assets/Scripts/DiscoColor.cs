using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoColor : MonoBehaviour {

    private float size;
    Color[] colors = new Color[6];
	// Use this for initialization
	void Start () {
        colors[0] = Color.red;
        colors[1] = Color.yellow;
        colors[2] = new Color32(255, 51, 0, 50);
        colors[3] = new Color32(204, 51, 0, 50);
        colors[4] = new Color32(255, 255, 102,50 );
        colors[5] = new Color32(255, 255, 153,50);

        size = Random.Range(0.3f, 0.8f);
        gameObject.transform.localScale = new Vector3(size, size, 0);
        gameObject.GetComponent<SpriteRenderer>().material.color = colors[Random.Range(0, colors.Length)];
    }
	
	// Update is called once per frame
	void Update () {
        
        gameObject.GetComponent<SpriteRenderer>().material.color = colors[Random.Range(0, colors.Length)];
        
    }
}
