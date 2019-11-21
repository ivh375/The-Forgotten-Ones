<<<<<<< Updated upstream
﻿using System.Collections;
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
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Collision collision;
    public int damage;
	


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            Enemy enemy = col.GameObject;
            Player player = GameObject.Find("SpaceShip").GetComponent<Player>();
            enemy.health(player.currentGun.shotPower, )
            //col.gameObject.SendMessage("health", player.currentGun.shotPower); // this destroys the enemy
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
>>>>>>> Stashed changes
