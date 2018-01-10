using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public float speed;
    public GameObject thrustSound;
    private float pos;

    public GameObject particlePrefab;
    private GameObject particle;

    

    // Use this for initialization
    void Start () {
        pos = transform.position.x;
        InvokeRepeating("increaseSpeed", 5.0f, 5.0f);
        
    }
	
    void increaseSpeed() {
        speed += 0.2f;
    }

	// Update is called once per frame
	void Update () {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
        if (Input.GetMouseButtonDown(0))
        {
            if (gameObject.GetComponent<SpriteRenderer>().enabled)
            {
                AudioSource thrustSoundPlay = thrustSound.GetComponent<AudioSource>();
                thrustSoundPlay.Play();
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
                particle = Instantiate(particlePrefab, (new Vector2(gameObject.transform.position.x, gameObject.transform.position.y-0.9f)), Quaternion.identity) as GameObject;
                Destroy(particle, 0.2f);
            }
        }
        
            
        
    }
}
