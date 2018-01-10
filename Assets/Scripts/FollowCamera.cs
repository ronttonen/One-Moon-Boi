using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public GameObject camera;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - camera.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = new Vector3(camera.transform.position.x + offset.x, 6.5f, 0);
    }
}
