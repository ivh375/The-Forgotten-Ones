using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public int fireRate, shotPower, bulletSpeed, rarity;

    public Weapon(int rate, int power, int speed, int rarity)
    {
        this.fireRate = rate;
        this.shotPower = power;
        this.bulletSpeed = speed;
        this.rarity = rarity;
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

