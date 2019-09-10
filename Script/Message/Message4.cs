using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message4 : MonoBehaviour {
    
    public Text text;

    public void OnTriggerEnter(Collider other)
    {
        text.text = "Ambil kunci untuk membuka pintu keluar dari tempat ini";
        Invoke("DisableText", 3f);
    }

    void DisableText()
    {
        text.text = "";
        Destroy(gameObject);
    }
}
