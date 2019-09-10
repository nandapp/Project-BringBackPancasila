using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnZombie : MonoBehaviour {

    public AudioClip sound;
    public GameObject zombie;
    //public Transform target;
    //public float speed;
    private string testText = "Raaawwwrrr !!!";
    public int x; public int y; public int z; 
    private Vector3 spawnSpot = new Vector3(0, 0, 0);
    public Text text;
    //float x = 20.63265f; float y = 39.17801f; float z = 80.84428f;

    private void OnTriggerEnter(Collider other)
    {
        text.text = testText;
        Invoke("DisableText", 3f);
        if (GameObject.Find("z@walk(Clone)") == null)
        {
            spawn();
        }
        else if (GameObject.Find("z@walk(Clone)") != null)
        {
            Destroy(GameObject.Find("z@walk(Clone)"));
            spawn();
        }
    }

    void spawn()
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        GetComponent<AudioSource>().PlayOneShot(sound);
        GameObject cubeSpawn = (GameObject)Instantiate(zombie, new Vector3(x, y, z), transform.rotation);
    }

    void DisableText()
    {
        text.text = "";
    }

    //zombie.SetActive(true);
    //float step = speed * Time.deltaTime;
    //transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    //zombie.transform.position = new Vector3(x, y, z);
    //Instantiate(zombie);
    //Destroy(gameObject, sound.length);

    //text.text = "test";
    //Invoke("DisableText", 5f);


    /*private void OnTriggerExit(Collider other)
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        //GetComponent<AudioSource>().PlayOneShot(sound);
        Destroy(GameObject.Find("z@walk(Clone)"));
        //GameObject cubeSpawn = (GameObject)Instantiate(zombie, new Vector3(88, 10, -22), transform.rotation);
        //zombie.SetActive(false);
        //zombie.transform.position = new Vector3(x, y, z);
        //Destroy(zombie);
        //Destroy(gameObject, sound.length);

    }*/

    // Use this for initialization
    void Start ()
    {
        //zombie.SetActive(false);
        //zombie.transform.position = new Vector4(x, y, 20, 39);
        //Destroy(zombie);
    }

    

    // Update is called once per frame
    void Update ()
    {

    }
}
