using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public states currentState;
	public float speed = 10f;
	public Rigidbody2D rb;
	[Header("Sine Wave Movement")]
	public float amplitude = 5f;
	public float period = 0.75f;
	public float shift = 1f;
	public float yChange = 0.075f;
	private float newX;
	private float newY;
	public enum states{
		straight,
		wavy,
		loop
	}
	
	
	
	// Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentState){
			case states.straight:
			rb.velocity = new Vector2(rb.velocity.x, -speed);
				break;
			case states.wavy:
				newY = transform.position.y - yChange;
				newX = amplitude * Mathf.Sin(period * newY) + shift;
				Vector2 tempPosition = new Vector2(newX, newY);
				transform.position = tempPosition;
				break;
			case states.loop:
				break;
			default:
				break;
		}
    }
}
