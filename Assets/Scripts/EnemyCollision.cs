using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public GameObject Bullet;
	public GameObject Enemy;
	private Enemy enemy;

   /*  Collision collision;
	void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag.Equals("Bullet"))
        {
            enemy.health(50f); 
            Destroy(col.Bullet); // this destroys the bullet
        }
    } */
}
