using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message6 : MonoBehaviour {
    
    public Text text;

    public void OnTriggerEnter(Collider other)
    {
        text.text = "Hidupkan lampu belajar untuk menerangi masa depanmu";
        Invoke("DisableText", 3f);
    }

    void DisableText()
    {
        text.text = "";
        Destroy(gameObject);
    }
}
