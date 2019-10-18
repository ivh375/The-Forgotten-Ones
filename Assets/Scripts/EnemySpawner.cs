using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnRate = 0.4f;
	public GameObject Enemy;
	private float nextTimeToSpawn = 0.0f;
	public states currentState;
	public enum states{
		straight,
		wavy
	}
    // Start is called before the first frame update
    void Start()
    {
        Enemy.SendMessage("switch(currentState");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTimeToSpawn) {
			Instantiate(Enemy);
			nextTimeToSpawn = Time.time + 1f / spawnRate;
		}
    }
}
