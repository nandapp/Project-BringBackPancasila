using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message1 : MonoBehaviour {
    
    public Text text;

    public void OnTriggerEnter(Collider other)
    {
        text.text = "Tekan [E] untuk berinteraksi";
        Invoke("DisableText", 3f);
    }

    void DisableText()
    {
        text.text = "";
        Destroy(gameObject);
    }
}
