using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lastDoor : MonoBehaviour {

    public Text text;

    public void lastD()
    {
        if (GameObject.FindGameObjectWithTag("Key") == null)
        {
            Debug.Log("YESS");
            SceneManager.LoadScene("ENDING");
        }
        else
        {
            Debug.Log("NOOO");
            text.text = "LOCKED";
            Invoke("DisableText", 3f);
        }
    }

    void DisableText()
    {
      text.text = "";
    }

// Use this for initialization
void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
