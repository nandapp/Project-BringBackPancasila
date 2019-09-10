using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour {
    
    public Text text;
    //public AudioClip sound;


    public void OnTriggerStay(Collider other)
    {    
        text.text = "Baca petunjuk sebelum lanjut kelantai atas";   
    }

    public void OnTriggerExit(Collider other)
    {
        text.text = "";
    }
}
