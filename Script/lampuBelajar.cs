using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampuBelajar : MonoBehaviour
{

    public AudioClip sound;
	public AudioClip sound1;
    public Light lampuB;
    private bool isActive = true;
    public GameObject wall;
    public GameObject wc;

    //public AudioClip sound;

    //public Animator anim;


    public void idupLampu()
    {
        isActive = !isActive;
        GetComponent<AudioSource>().PlayOneShot(sound);
        Destroy(wall, sound.length);
        Destroy(wc, sound.length);

        if (isActive == false)
        {
            lampuB.enabled = true;
			GetComponent<AudioSource>().PlayOneShot(sound1);
            //anim.SetBool("isBool", true);
            //GetComponent<Animation>().Play();
        }
        else if (isActive == true)
        {
            lampuB.enabled = false;
            //anim.SetBool("isBool", true);
            //GetComponent<Animation>().Stop();
        }
    }

	// Use this for initialization
	void Start ()
    {
        lampuB.enabled = false;
        //anim.Stop();
        //anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
