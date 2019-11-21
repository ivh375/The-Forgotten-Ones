using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int CurrHealth = 200;
    public WeaponManager wm;
    public Player player;
    public GameObject dropPrefab;
    public GameObject dropPrefab1;
    public GameObject dropPrefab2;

    public void health(int damage){
        CurrHealth = CurrHealth - damage;
        //health check
        if (CurrHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject); //destroys enemy
        Weapon newWeapon = wm.GenerateWeapon(player);
        CreateDrop(newWeapon, pos);
    }

    public void CreateDrop(Weapon newWeapon, vector3 pos)
    {
        if (newWeapon.rarity == 1)
        {
            dropPrefab = Instantiate(dropPrefab, .position, .rotation);
        }
        else if(newWeapon.rarity == 2)
        {
            dropPrefab = Instantiate(dropPrefab1, .position, .rotation);
        }
        else
        {
            dropPrefab = Instantiate(dropPrefab2, .position, .rotation);
        }
        
    }
	
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("SpaceShip").GetComponent<Player>();
        wm = GameObject.Find("SpaceShip").GetComponent<WeaponManager>();
    }

    // Update is called once per frame
    void Update()
    {
		
    }
}
