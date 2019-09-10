using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawner : MonoBehaviour
{

    //reference to all spawner object
    public GameObject[] spawnPoints;
    //reference to the object we want to spawn
    public GameObject gameObjectToSpawn;

	// Use this for initialization
	void Start ()
    {
        
	}

    public void calls()
    {
        //Find all the spawn points in the scene
        spawnPoints = GameObject.FindGameObjectsWithTag("Spawner");

        //Calls the spawn Method
        Spawn();
    }
	
    //select one of our spawner randomly and this also going to return the selectedSpawner
    GameObject SelectRandomSpawner()
    {
        GameObject selectedSpawner;
        selectedSpawner = spawnPoints[Random.Range(0, spawnPoints.Length)];

        return selectedSpawner;
    }

    //spawn the object
    void Spawn()
    {
        Instantiate(gameObjectToSpawn, SelectRandomSpawner().transform.position, SelectRandomSpawner().transform.rotation);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
