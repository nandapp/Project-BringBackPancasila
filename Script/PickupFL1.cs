using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupFL1 : MonoBehaviour {

    public AudioClip pickupSound;
    public GameObject flashlight;
    public GameObject Slide;
    public Camera camera1;
    public Text text;

    void Start()
    {
        flashlight.SetActive(true);
        camera1.enabled = true;
        Slide.SetActive(true);
    }

    public void pickupFlash()
    {
        text.text = "Tekan [F] untuk menghidupkan senter";
        Invoke("DisableText", 3f);

        GetComponent<AudioSource>().PlayOneShot(pickupSound);
        flashlight.SetActive(true);
        camera1.enabled = true;
        Slide.SetActive(true);

        Destroy(gameObject, pickupSound.length);
    }

    void DisableText()
    {
        text.text = "";
    }

    // Use this for initialization

    // Update is called once per frame
    void Update ()
    {
    }
}
