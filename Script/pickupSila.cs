using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupSila : MonoBehaviour {

    public AudioClip pickupSound;

    public void pickupSila1()
    {
        GetComponent<AudioSource>().PlayOneShot(pickupSound);

        Destroy(gameObject, pickupSound.length);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
