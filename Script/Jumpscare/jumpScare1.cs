using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScare1 : MonoBehaviour {

	public GameObject corpse;
    public AudioClip soundHorror;
    private AudioSource AS;

    // Use this for initialization
    void Start ()
    {
        corpse.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        corpse.SetActive(false);
        GetComponent<AudioSource>().PlayOneShot(soundHorror);
        Destroy(gameObject, soundHorror.length);
    }


    // Update is called once per frame
    void Update ()
    {
    }
}
