using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMap : MonoBehaviour {

    private GameObject floor;
    private float lastPos;
    private float lastPosWallForWalls;
    private GameObject FloorTile;
    private GameObject CeilingTile;
    private GameObject WallTile;
    public GameObject FloorTilePrefab;
    public GameObject CeilingTilePrefab;
    public GameObject WallTilePrefab;

    private float ceilingHeight;
    private float floorHeight;
    private bool start = true;

	// Use this for initialization
	void Start () {
        
        lastPos = transform.position.x;
        lastPosWallForWalls = transform.position.x;
        generatePlatform();
        InvokeRepeating("SpawnObsticles", 1.0f, 0.4f);
        StartCoroutine("moreObsticles");
        
    }

    void generatePlatform()
    {
        
        if (transform.position.x < 150)
        {
            ceilingHeight = 20;
            floorHeight = -7;
            if (start)
            {   for (int y = -15; y < 25; y++)
                {
                    FloorTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + y, floorHeight, 0), Quaternion.identity) as GameObject;
                    CeilingTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + y, ceilingHeight, 0), Quaternion.identity) as GameObject;
                }
                for (int y = -15; y < 25; y++)
                {
                    FloorTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + y, floorHeight-1, 0), Quaternion.identity) as GameObject;
                    CeilingTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + y, ceilingHeight+1, 0), Quaternion.identity) as GameObject;
                }
                for (int y = -15; y < 25; y++)
                {
                    FloorTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + y, floorHeight-2, 0), Quaternion.identity) as GameObject;
                    CeilingTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + y, ceilingHeight+2, 0), Quaternion.identity) as GameObject;
                }


                start = false;
            }
        }
        else if (150 < transform.position.x && transform.position.x < 300)
        {
            ceilingHeight = 19.0f;
            floorHeight = -6.0f;
        }
        else if (450 < transform.position.x && transform.position.x < 600)
        {
            ceilingHeight = 18.0f;
            floorHeight = -5.0f;
        }
        else if (600 < transform.position.x && transform.position.x < 750)
        {
            ceilingHeight = 17.0f;
            floorHeight = -4.0f;
        }
        else if (750 < transform.position.x && transform.position.x < 900)
        {
            ceilingHeight = 16.0f;
            floorHeight = -3.0f;
        }
        else if (900 < transform.position.x && transform.position.x < 1050)
        {
            ceilingHeight = 15.0f;
            floorHeight = -2.0f;
        }
        else if (1050 < transform.position.x && transform.position.x < 1200)
        {
            ceilingHeight = 14.0f;
            floorHeight = -1.0f;
        }
        else if (1200 < transform.position.x && transform.position.x < 1350)
        {
            ceilingHeight = 13.0f;
            floorHeight = 0.0f;
        }
       
       for (int i = 0; i < 50; i++)
        {
            FloorTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + 1 + i, floorHeight, 0), Quaternion.identity) as GameObject;
            CeilingTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + 1 + i, ceilingHeight, 0), Quaternion.identity) as GameObject;
        }
        for (int i = 0; i < 50; i++)
        {
            FloorTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + 1 + i, floorHeight-2, 0), Quaternion.identity) as GameObject;
            CeilingTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + 1 + i, ceilingHeight+2, 0), Quaternion.identity) as GameObject;
        }
        for (int i = 0; i < 50; i++)
        {
            FloorTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + 1 + i, floorHeight-3, 0), Quaternion.identity) as GameObject;
            CeilingTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + 1 + i, ceilingHeight+3, 0), Quaternion.identity) as GameObject;
        }
        for (int i = 0; i < 50; i++)
        {
            FloorTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + 1 + i, floorHeight-4, 0), Quaternion.identity) as GameObject;
            CeilingTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + 1 + i, ceilingHeight+4, 0), Quaternion.identity) as GameObject;
        }
        for (int i = 0; i < 50; i++)
        {
            FloorTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + 1 + i, floorHeight - 5, 0), Quaternion.identity) as GameObject;
            CeilingTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + 1 + i, ceilingHeight + 5, 0), Quaternion.identity) as GameObject;
        }
        for (int i = 0; i < 50; i++)
        {
            FloorTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + 1 + i, floorHeight - 6, 0), Quaternion.identity) as GameObject;
            CeilingTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + 1 + i, ceilingHeight + 6, 0), Quaternion.identity) as GameObject;
        }
        for (int i = 0; i < 50; i++)
        {
            FloorTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + 1 + i, floorHeight - 7, 0), Quaternion.identity) as GameObject;
            CeilingTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + 1 + i, ceilingHeight + 7, 0), Quaternion.identity) as GameObject;
        }
        for (int i = 0; i < 50; i++)
        {
            FloorTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + 1 + i, floorHeight - 8, 0), Quaternion.identity) as GameObject;
            CeilingTile = Instantiate(CeilingTilePrefab, new Vector3(lastPos + 1 + i, ceilingHeight + 8, 0), Quaternion.identity) as GameObject;
        }

        lastPos = FloorTile.transform.position.x;
    }

    void SpawnObsticles()
    {
        
        WallTile = Instantiate(WallTilePrefab, new Vector3(Random.Range(lastPosWallForWalls + 25, lastPosWallForWalls + 50), Random.Range(floorHeight+2, ceilingHeight-2), 0), Quaternion.identity) as GameObject;
        lastPosWallForWalls = transform.position.x;

    }

    IEnumerator moreObsticles()
    {
        yield return new WaitForSeconds(60);
        CancelInvoke();
        InvokeRepeating("SpawnObsticles", 0.5f, 0.5f);
        StartCoroutine("evenMoreObsticles");
    }

    IEnumerator evenMoreObsticles()
    {
        yield return new WaitForSeconds(240);
        CancelInvoke();
        InvokeRepeating("SpawnObsticles", 0.4f, 0.4f);
        StartCoroutine("mostObsticles");
    }

    IEnumerator mostObsticles()
    {
        yield return new WaitForSeconds(300);
        CancelInvoke();
        InvokeRepeating("SpawnObsticles", 0.3f, 0.3f);
    }

	// Update is called once per frame
	void Update () {

        
		if (transform.position.x >= lastPos -100)
        {
            generatePlatform();
        }
	}
}
