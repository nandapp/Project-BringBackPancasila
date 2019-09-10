using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScare : MonoBehaviour {

	public GameObject nenekGayung;
	public AudioClip soundHorror2;
    public AudioClip soundHorror;
    private AudioSource AS;
    public Light SpotLight;

    // Use this for initialization
    void Start ()
    {
        nenekGayung.SetActive(false);
        SpotLight.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        nenekGayung.SetActive(true);
		SpotLight.enabled = true;
		GetComponent<AudioSource>().PlayOneShot(soundHorror2);
        GetComponent<AudioSource>().PlayOneShot(soundHorror);
        Destroy(nenekGayung, soundHorror.length);
        Destroy(gameObject, soundHorror.length);
        Destroy(GameObject.Find("cubeProtector"), soundHorror.length);
        
    }


    // Update is called once per frame
    void Update ()
    {
    }
}
