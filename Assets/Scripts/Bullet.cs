using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Collision collision;
	private float damage = 50f; //to be recieved from weapon class
	


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            col.gameObject.SendMessage("health", damage); // this destroys the enemy
            Destroy(gameObject); // this destroys the bullet
        }
    }
	
	
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
