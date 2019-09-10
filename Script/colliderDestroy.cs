using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderDestroy : MonoBehaviour 
	{
	public GameObject guiobject;

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
				
			}
		}
	}

	void OnTriggerExit()
	{
		guiobject.SetActive(false);
	}

	// Use this for initialization
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
