<<<<<<< Updated upstream
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
	public Transform firePoint;
	public GameObject bulletPrefab;
	public float bulletForce = 20f;
	
    // Update is called once per frame
    void Update()
    {
    	if (Input.GetButtonDown("Fire1"))
    	{
    		Shoot();
    	}
    }

    void Shoot()
    {
    	GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    	Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
    	rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet, 3);
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
	public Transform firePoint;
	public GameObject bulletPrefab;
    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public float bulletForce = 20f;
    Player player;
	
    // Update is called once per frame
    void Update()
    {
    	if (Input.GetButtonDown("Fire1"))
    	{
    		Shoot();
    	}
    }

    void Shoot()
    {
        GameObject bullet;
        player = GameObject.Find("SpaceShip").GetComponent<Player>();
        if (player.currentGun.rarity == 1)
        {
            bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
        else if(player.currentGun.rarity == 2)
        {
            bullet = Instantiate(bulletPrefab1, firePoint.position, firePoint.rotation);
        }
        else
        {
            bullet = Instantiate(bulletPrefab2, firePoint.position, firePoint.rotation);
        }
    	Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
    	rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet, 2);
    }
}
>>>>>>> Stashed changes
