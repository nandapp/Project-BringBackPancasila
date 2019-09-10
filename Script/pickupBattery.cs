using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupBattery : MonoBehaviour {

    public float batteryPower;
    public AudioClip pickupSound;

    public void pickupBatt()
    {
        GetComponent<AudioSource>().PlayOneShot(pickupSound);
        GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Flashlight>().AddBatteryLife(batteryPower);
        //GetComponent<Flashlight>().AddBatteryLife(batteryPower);
        Destroy(gameObject, pickupSound.length);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
