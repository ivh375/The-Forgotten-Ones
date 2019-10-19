using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    public float spawnRate = 0.4f;
    public state currentState;
    public float speed = 10f;
    [Header("Sine/Cos Movement Modifiers")]
    public float amplitude = 5f;
    public float period = 0.75f;
    public float shift = 1f;
    public float yChange = 0.075f;
    [Header("Y Speed loop behaviour")]
    public float yChangeMod = 0.03f;
    private float nextTimeToSpawn = 0.0f;
    private Vector2 spawnLocation;
	
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
    [System.Obsolete]
    void Update()
    {
        if (Time.time >= nextTimeToSpawn) {
            nextTimeToSpawn = Time.time + 1f / spawnRate;
            spawnLocation = new Vector2(transform.position.x, transform.position.y);
            //instantiates enemy into game as "obj"
			GameObject obj = Instantiate(Enemy, spawnLocation, Quaternion.identity);
            //sets enemy to be child of spawner
            obj.transform.parent = transform;
            //Destroys enemy after 10 seconds ( couldnt get isOffScreen -> Destroy type thing to work)
            Destroy(obj, 10);

            
        }
    }
    
}
