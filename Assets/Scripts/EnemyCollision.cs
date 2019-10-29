using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public GameObject bullet;
    public GameObject Enemy;
    private Collision other;

    private void OnTriggerEnter2D(Collider2D other)
    {
            Destroy(other.gameObject); // this destroys the enemy
            Destroy(bullet); // this destroys the bullet        }
    }
}
