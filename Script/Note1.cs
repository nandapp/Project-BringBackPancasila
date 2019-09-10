using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Note1 : MonoBehaviour
{

    public GameObject collDes;
    public Image noteImage;
    public Text text;
    //public GameObject hideNoteButton;

    public AudioClip pickupSound;
    public AudioClip putAwaySound;

    public GameObject PlayerObject;

    // Use this for initialization
    void Start ()
    {
        text.text = "ini dimana ?";
        Invoke("DisableText", 3f);
        noteImage.enabled = false;
        //hideNoteButton.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    void DisableText()
    {
        text.text = "";
    }

    public void showNoteImage()
    {

        text.text = "TEKAN [C] UNTUK KEMBALI";
        noteImage.enabled = true;
        GetComponent<AudioSource>().PlayOneShot(pickupSound);

        //hideNoteButton.SetActive(true);

        //Disable the player
        PlayerObject.GetComponent<FirstPersonController>().enabled = false;
        Destroy(collDes);

        //Unlock the cursor
        //Cursor.lockState = CursorLockMode.None;
        //Cursor.visible = true;



    }

    public void hideNoteImage()
    {
        text.text = "rahasia ?";
        Invoke("DisableText", 3f);
        noteImage.enabled = false;
        GetComponent<AudioSource>().PlayOneShot(putAwaySound);

        //hideNoteButton.SetActive(false);

        //Enable the player
        PlayerObject.GetComponent<FirstPersonController>().enabled = true;

        //Lock the cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update ()
    {
        
    }
}
