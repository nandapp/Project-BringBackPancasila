using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message2 : MonoBehaviour {
    
    public Text text;
    public AudioClip sound;


    public void OnTriggerEnter(Collider other)
    {
        text.text = "Cahaya senter akan meredup seiring berjalan nya waktu";
        GetComponent<AudioSource>().PlayOneShot(sound);
        Invoke("DisableText", 3f);
    }

    void DisableText()
    {
        text.text = "";
        Destroy(gameObject);
    }
}
