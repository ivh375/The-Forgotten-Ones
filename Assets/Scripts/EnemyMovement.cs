using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public states currentState;
    private EnemySpawner parentSpawner;
	public float speed = 10f;
	public Rigidbody2D rb;
	[Header("Sine/Cos Movement Modifiers")]
	public float amplitude = 5f;
	public float period = 0.75f;
	public float shift = 1f;
	public float yChange = 0.075f;
    [Header("Y Speed loop behaviour")]
    public float yChangeMod = 0.03f;
    private float newX;
	private float newY;
    private float x;
    private float y;
	public enum states{
		straight,
		wavy,
		loop
	}
	
	
	// Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //following code passes movement type value set in spawner to the enemy object here:
        EnemySpawner enemySpawner = GetComponentInParent<EnemySpawner>();
        speed = enemySpawner.speed;
        amplitude = enemySpawner.amplitude;
        period = enemySpawner.period;
        shift = enemySpawner.shift;
        yChange = enemySpawner.yChange;
        yChangeMod = enemySpawner.yChangeMod;
        if (enemySpawner.currentState == 0)
        {
            currentState = 0;
        } else if (enemySpawner.currentState == EnemySpawner.state.wavy)
        {
            currentState = states.wavy;
        }
        else if (enemySpawner.currentState == EnemySpawner.state.loop)
        {
            currentState = states.loop;
        }

    }


    // Update is called once per frame
    void Update()
    {
        //enemy movement patterns implemented here in given states
        switch(currentState){
			case states.straight:
			rb.velocity = new Vector2(rb.velocity.x, -speed);
				break;
			case states.wavy:
				newY = transform.position.y - yChange;
				newX = amplitude * Mathf.Sin(period * newY) + shift;
				Vector2 tempPosition = new Vector2(newX + transform.parent.position.x - 2.5f, newY);
				transform.position = tempPosition;
				break;
			case states.loop:
                yChange = yChange + yChangeMod;
                x = amplitude * Mathf.Cos(Time.time * speed);
                y = amplitude * Mathf.Sin(Time.time * speed) - yChange;
                transform.position = new Vector2(x, y + transform.parent.position.y);
                break;
			default:
				break;
		}
    }
}
