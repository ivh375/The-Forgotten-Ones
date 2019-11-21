using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement movement;


	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag.Equals ("Enemy"))
		{
			SoundManager.PlaySound("ExplosionSound");
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
