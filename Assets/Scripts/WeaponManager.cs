using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    // Creates a randomizd weapon
    public void GenerateWeapon(Player player)
    {
        Weapon newWeapon;
        float rand = Random.Range(1f, 100f);
        if (rand < 60)
        {
            newWeapon = new Weapon((int)Random.Range(0, 4), (int)Random.Range(50, 100), (int)Random.Range(0, 4), 1);
        }
        else if (rand >= 60 && rand <= 95)
        {
            newWeapon = new Weapon((int)Random.Range(5, 7), (int)Random.Range(100, 150), (int)Random.Range(5, 7), 2);
        }
        else
        {
            newWeapon = new Weapon((int)Random.Range(8, 10), (int)Random.Range(150, 200), (int)Random.Range(8, 10), 3);
        }
        player.currentGun = newWeapon;
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
