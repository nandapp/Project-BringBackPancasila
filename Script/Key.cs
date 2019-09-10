using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
   // public Door myDoor;
    public AudioClip pickupSound;
    private AudioSource audiosource;
    
	// Use this for initialization
	void Start ()
    {
        audiosource = GetComponent<AudioSource>();
	}
	
    public void unlockDoor()
    {
        //myDoor.isLocked = false;
        audiosource.PlayOneShot(pickupSound);
        
        StartCoroutine("WaitForSelfDestruct");
    }

    IEnumerator WaitForSelfDestruct()
    {
        yield return new WaitForSeconds(pickupSound.length);
        Destroy(gameObject);
    }
}
