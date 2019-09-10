using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupFL : MonoBehaviour {

    public AudioClip pickupSound;
    public GameObject flashlight;
    public GameObject Slide;
    public Camera camera1;
    public Text text;

    // Use this for initialization
    void Start()
    {
        flashlight.SetActive(false);
        camera1.enabled = false;
        Slide.SetActive(false);
    }

    public void pickupFlash()
    {
        GetComponent<AudioSource>().PlayOneShot(pickupSound);
        flashlight.SetActive(true);
        camera1.enabled = true;
        Slide.SetActive(true);

        text.text = "Tekan [F] untuk menghidupkan senter";
        Invoke("DisableText", 2f);

        Destroy(gameObject, pickupSound.length);
    }

    void DisableText()
    {
        text.text = "";
    }

    // Update is called once per frame
    void Update ()
    {
    }
}
