using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float CurrHealth = 100f;
	
	public void health(float damage){
		CurrHealth = CurrHealth - damage;
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //health check
		if (CurrHealth <= 0f){
			Destroy(gameObject); //destroys enemy
		}
		
    }
}
