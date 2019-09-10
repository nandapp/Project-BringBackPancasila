using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Flashlight : MonoBehaviour {

    public KeyCode flashlightToggleKey = KeyCode.F;
    public float batteryLifeinSecond = 0.001f;
    public float maxIntensity = 5f;

    private static float batteryLife;
    public bool isActive = false;

    //private bool isPaused;
    //public GameObject PlayerObject;
    //public string interactButton;
    //public Image noteImage;
    public Light FlashLight;
    public AudioSource audioSource;
    public AudioClip soundFlashToggle;
    //public AudioClip soundFlashLighton;
    //public AudioClip soundFlashLightoff;

    public Slider battSlider;
    //public GameObject battSlide;
    private bool isShowing;

    
	// Use this for initialization
	void Start ()
    {
        batteryLife = FlashLight.intensity;

        if (Input.GetKeyDown("p"))
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

        //isActive = false;
        //GameObject.Find("Slider").SetActive(true);
        //battSlide.SetActive(isShowing);
        //battSlide.SetActive(false);
        //noteImage.enabled = false;

        //isPaused = !isPaused;      
    }

    /*void pause()
    {
        noteImage.enabled = true;
        PlayerObject.GetComponent<FirstPersonController>().enabled = false;
    }

    void unpause()
    {
        noteImage.enabled = false;
        PlayerObject.GetComponent<FirstPersonController>().enabled = true;
    }*/

    // Update is called once per frame
    // use this for input
    public void Update ()
    {
		if(Input.GetKeyDown(flashlightToggleKey))
        {
            isActive = !isActive;
            //isShowing = !isShowing;

            if (audioSource != null && soundFlashToggle != null)
                audioSource.PlayOneShot(soundFlashToggle);

            if (isActive == false)
            {
                FlashLight.enabled = true;
                //battSlider.enabled = true;
                //battSlide.SetActive(isShowing);
                //isActive = true;

                //audioSource.PlayOneShot(soundFlashLighton);
            }
            else if (isActive == true)
            {
                FlashLight.enabled = false;
                //isActive = false;

                //audioSource.PlayOneShot(soundFlashLightoff);
            }
        }

        if (isActive == false)
        FlashLight.intensity -= batteryLife / batteryLifeinSecond * Time.deltaTime;
        battSlider.value = FlashLight.intensity;

        /*if (isPaused == false)
        {
            if (Input.GetButtonDown(interactButton))
                pause();
        }
        else
        {
            if (Input.GetButtonDown(interactButton))
                unpause();
        }*/
    }

    public void AddBatteryLife(float _batteryPower)
    {
        FlashLight.intensity += _batteryPower;
        if (FlashLight.intensity > maxIntensity)
            FlashLight.intensity = maxIntensity;
            battSlider.value = FlashLight.intensity;
    }
}

