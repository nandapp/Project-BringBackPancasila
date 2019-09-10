using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScare3 : MonoBehaviour {

    public AudioClip sound;
    public Door myDoor;

    private void OnTriggerExit(Collider other)
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        GetComponent<AudioSource>().PlayOneShot(sound);
        myDoor.ChangeDoorState();
        Destroy(gameObject, sound.length);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
