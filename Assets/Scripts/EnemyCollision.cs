using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public GameObject Bullet;
    private Collision other;

    private void OnTriggerEnter2D(Collider2D other)
    {
		gameObject.SendMessage("health", Bullet.GetComponent("damage"));
        Destroy(Bullet); // this destroys the bullet        }
    }
}
