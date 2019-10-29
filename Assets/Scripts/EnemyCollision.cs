using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public GameObject bullet;
    public GameObject enemy;
    private Collision other;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // this destroys the enemy
            Destroy(bullet); // this destroys the bullet
        }
    }

// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnCollisionEnter(other);
    }
}
