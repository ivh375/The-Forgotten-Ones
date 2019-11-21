using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnArray : MonoBehaviour
{
	//Based on the way i'm doing this script it may need to be part of an 
	//even large container script that calls upon this, but we'll see.
	//It also even seem like i could throw out or reimplement the EnemySpawner script,
	//all into one thing working like this, but hold off.
	
	public GameObject location;   //This contains empty oject from spawn array to pass transform coordinates
	public GameObject enemySpawner;  //the EnemySpawner object to instantiate
	public float spawnRate = 0.4f;
	private float nextTimeToSpawn = 0.0f;
	
	void InstantiateSpawner(GameObject location, GameObject enemySpawner){
		Vector2 spawnLocation = new Vector2(location.transform.position.x, location.transform.position.y);
        //instantiates enemySpawner into game as "obj"
		GameObject obj = Instantiate(enemySpawner, spawnLocation, Quaternion.identity);
		Destroy(obj, 14);
            //sets enemy to be child of spawner
            //obj.transform.parent = transform;
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTimeToSpawn) {
            nextTimeToSpawn = Time.time + 1f / spawnRate;
			InstantiateSpawner(location, enemySpawner);
		}
    }
}
