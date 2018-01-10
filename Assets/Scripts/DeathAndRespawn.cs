using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using System.IO;

public class DeathAndRespawn : MonoBehaviour {

    public GameObject respawnPosition;
    public GameObject gameOverText;
    public GameObject playAgainButton;
    public GameObject mainMenuButton;

    public GameObject deathAnimationSpritePrefab;
    private GameObject explosion_1;


    public Text gameOverScoreText;
    public Text scoreText;

    
    public GameObject deathScream;


    private int score;
    private bool even = true;

   

    // Use this for initialization
    void Start () {
        if(PlayerPrefs.GetInt("muted") == 1)
        {
            AudioListener.pause = true;
        } else
        {
            AudioListener.pause = false;
        }

        score = 0;
        gameOverScoreText.GetComponent<Text>().enabled = false;
        gameOverText.SetActive(false);
        playAgainButton.SetActive(false);
        mainMenuButton.SetActive(false);
       InvokeRepeating("CountScore", 0.05f, 0.05f);
        
        
    }

    void CountScore()
    {
        if (even)
        {
            score += 1;
            even = false;
        }
        else
        {
            score += 2;
            even = true;
        }

        scoreText.text = "Score: " + score.ToString();
        
    }

    void OnTriggerEnter2D(Collider2D collision2D)
    {
        Debug.Log("Colission");
    
        if (collision2D.gameObject.tag == "WallTile")
        {
            if (gameObject.GetComponent<SpriteRenderer>().enabled)
            {
                AudioSource deathScreamPlay = deathScream.GetComponent<AudioSource>();
                deathScreamPlay.Play();
                DeathAnimation();
            }
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            
            GameOver();

        }
    }

    void DeathAnimation()
    {
        explosion_1 = Instantiate(deathAnimationSpritePrefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity) as GameObject;
        Destroy(explosion_1, 0.5f);
    }

    void GameOver()
    {
        
        scoreText.GetComponent<Text>().enabled = false;
        gameOverScoreText.text = "Your score: " + score.ToString();
       gameOverScoreText.GetComponent<Text>().enabled = true;
       gameOverText.SetActive(true);
       playAgainButton.SetActive(true);
        mainMenuButton.SetActive(true);
        CancelInvoke();
        SaveHighScore(score);
        StartCoroutine("Wait");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(30);

        SceneManager.LoadScene("mainMenu");
    }

    void SaveHighScore(int myHighScore)
    {

        string key = "highscore";
        int highScore = myHighScore;


        if (PlayerPrefs.GetInt(key) <= highScore)
        {
            PlayerPrefs.SetInt(key, highScore);
        }
            

       

        PlayerPrefs.Save();

    }

    // Update is called once per frame
    void Update () {
        
    }
}
