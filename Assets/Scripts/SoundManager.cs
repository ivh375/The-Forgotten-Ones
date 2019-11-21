using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

	public static AudioClip LaserSound, ExplosionSound;
	static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        LaserSound = Resources.Load<AudioClip> ("LaserSound");
        ExplosionSound = Resources.Load<AudioClip> ("ExplosionSound");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
    	switch(clip)
    	{
    		case "LaserSound":
    			audioSrc.PlayOneShot(LaserSound);
    			break;
            case "ExplosionSound":
                audioSrc.PlayOneShot(ExplosionSound);
                break;
    	}
    }
}
