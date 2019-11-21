using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        Drop drop = col.GetComponent<Drop>();
        if (drop != null)
        {
            Player player = GameObject.Find("SpaceShip").GetComponent<Player>();
            col.gameObject.SendMessage("health", player.currentGun.shotPower); // this destroys the enemy
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
