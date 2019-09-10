using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	[SerializeField]
	private Text test = null;
	public int fontSize;
	//public string newString;
	public Color newColor;

	public GameObject battSlide;
	private bool isShowing;

	string test1 = "WHAT ?";
	string test2 = "DAFUQ";

	// Use this for initialization
	void Start () 
	{
		test.text = test1;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//test.text = newString;
		//test.fontSize = fontSize;
		//test.color = newColor;

		if (Input.GetKey (KeyCode.E)) 
		{
			test.text = test2;
		} 
		else
		{
			test.text = test1;
		}


		if (Input.GetKeyDown (KeyCode.F))
			isShowing = !isShowing;
			battSlide.SetActive (isShowing);

	}
}
