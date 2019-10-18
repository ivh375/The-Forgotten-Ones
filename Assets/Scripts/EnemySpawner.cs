using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnRate = 0.4f;
	public GameObject Enemy;
	private float nextTimeToSpawn = 0.0f;
    private Vector2 spawnLocation;
	public state currentState;
	public enum state{
		straight,
		wavy,
        loop
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
            spawnLocation = new Vector2(transform.position.x, transform.position.y);
			GameObject obj = Instantiate(Enemy, spawnLocation, Quaternion.identity);
            obj.transform.parent = transform;
            

        }
    }
}
