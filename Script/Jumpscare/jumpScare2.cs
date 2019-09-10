using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScare2 : MonoBehaviour {

    public AudioClip sound;

    private void OnTriggerEnter(Collider other)
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        GetComponent<AudioSource>().PlayOneShot(sound);
        Destroy(gameObject, sound.length);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
