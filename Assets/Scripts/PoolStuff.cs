using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolStuff : MonoBehaviour {

    private GameObject player; 

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);


    }

    // Update is called once per frame
    void Update () {
        if (player.transform.position.x - transform.position.x > 50)
        {
            Destroy(gameObject);
        }
    }
}
