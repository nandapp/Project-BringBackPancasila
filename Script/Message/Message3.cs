using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message3 : MonoBehaviour {
    
    public Text text;

    public void OnTriggerEnter(Collider other)
    {
        text.text = "Temukan baterai untuk mengisinya kembali";
        Invoke("DisableText", 3f);
    }

    void DisableText()
    {
        text.text = "";
        Destroy(gameObject);
    }
}
