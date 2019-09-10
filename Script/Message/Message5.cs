using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message5 : MonoBehaviour {
    
    public Text text;
    public AudioClip sound;

    public void OnTriggerEnter(Collider other)
    {
        text.text = "Mahluk Jahat telah lepas dan akan mengejar kemanapun cahayamu pergi";
        GetComponent<AudioSource>().PlayOneShot(sound);
        Invoke("DisableText", 3f);
    }

    void DisableText()
    {
        text.text = "";
        Destroy(gameObject);
    }
}
