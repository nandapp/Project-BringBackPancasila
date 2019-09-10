using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerLoadLevel : MonoBehaviour {
    public GameObject guiobject;
    public string LevelToLoad;
    //private string p_pos;

	// Use this for initialization
	void Start () {
        guiobject.SetActive(false);
	}


    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guiobject.SetActive(true);
            if (guiobject.activeInHierarchy == true && Input.GetButtonDown("Use"))
            {
                //Application.LoadLevel(LevelToLoad);
                SceneManager.LoadScene(LevelToLoad);

                //p_pos = other.gameObject.tag == ("Move")();
                //pZ = PlayerPrefs.GetFloat("p_z");
                //GetComponent<Player>().position_save();
                //SceneManager.LoadScene(LevelToLoad);
            }
        }
    }

    void OnTriggerExit()
    {
        guiobject.SetActive(false);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
