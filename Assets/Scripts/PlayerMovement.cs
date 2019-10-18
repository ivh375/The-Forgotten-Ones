using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
	[Header("Player Bounds")]
	public float minY = -4f;
	public float maxY = 11.5f; 
	public float minX = -16f; 
	public float maxX = 16.7f;

    new Vector2 movement;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
	
	void MovePlayer(){
		if (Input.GetAxisRaw("Vertical") > 0f) {
			Vector3 temp = transform.position;
			temp.y += speed * Time.deltaTime;
			
			if (temp.y > maxY)
				temp.y = maxY;
			
			transform.position = temp;
		} else if (Input.GetAxisRaw("Vertical") < 0f) {
			Vector3 temp = transform.position;
			temp.y -= speed * Time.deltaTime;
			
			if (temp.y < minY)
				temp.y = minY;
			
			transform.position = temp;
		}
		if (Input.GetAxisRaw("Horizontal") > 0f) {
			Vector3 temp = transform.position;
			temp.x += speed * Time.deltaTime;
			
			if (temp.x > maxX)
				temp.x = maxX;
			
			transform.position = temp;
		} else if (Input.GetAxisRaw("Horizontal") < 0f) {
			Vector3 temp = transform.position;
			temp.x -= speed * Time.deltaTime;
			
			if (temp.x < minX)
				temp.x = minX;
			
			transform.position = temp;
		}

		
	}
	
    void FixedUpdate()
    {
		
    }
}
