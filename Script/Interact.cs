using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public string interactButton;
    public string closeButton;

    public float interactDistance;
    public LayerMask interactLayer; //Filter

    public Image interactIcon; //Picture that show you can interact or not

    private bool isInteracting = false;

    //public Text Instruction;
    //public string test;

	// Use this for initialization
	void Start ()
    {
        //set interact icon to be invisible
        if (interactIcon != null)
        {
            interactIcon.enabled = false;
        }

        //test = ("test");
        //print(test);
    }
	
	// Update is called once per frame
	void Update ()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        
        //Shoots a ray
        if(Physics.Raycast(ray, out hit, interactDistance, interactLayer))
        {
            //Checks if interacting
            if(isInteracting == false)
            {
                if(interactIcon != null)
                {
                    interactIcon.enabled = true;
                }
                
                //if we press the interaction button
                if(Input.GetButtonDown(interactButton))
                {
                    //If it is a door
                    if(hit.collider.CompareTag("Door"))
                    {
                        //Open/Close it
                        hit.collider.GetComponent<Door>().ChangeDoorState();
                    }
                    else if(hit.collider.CompareTag("Key"))
                    {
                        hit.collider.GetComponent<Key>().unlockDoor();
                    }
                    else if (hit.collider.CompareTag("Flaslight"))
                    {
                        hit.collider.GetComponent<PickupFL>().pickupFlash();
                    }
                    else if (hit.collider.CompareTag("Battery"))
                    {
                        hit.collider.GetComponent<pickupBattery>().pickupBatt();
                    }
                    else if (hit.collider.CompareTag("Sila"))
                    {
                        hit.collider.GetComponent<pickupSila>().pickupSila1();
                    }
                    else if (hit.collider.CompareTag("Note"))
                    {
                        hit.collider.GetComponent<Note>().showNoteImage();
                    }
                    else if (hit.collider.CompareTag("Note1"))
                    {
                        hit.collider.GetComponent<Note1>().showNoteImage();
                    }
					else if (hit.collider.CompareTag("lampuB"))
					{
						hit.collider.GetComponent<lampuBelajar>().idupLampu();
					}
                    else if (hit.collider.CompareTag("lampuB"))
                    {
                        hit.collider.GetComponent<lampuBelajar1>().idupLampu();
                    }
                    else if (hit.collider.CompareTag("lastD"))
                    {
                        hit.collider.GetComponent<lastDoor>().lastD();
                    }
					else if (hit.collider.CompareTag("Table"))
					{
						hit.collider.GetComponent<gameManager>().gameMNG();
						//Instruction.text = (test);
					}
                    else if (hit.collider.CompareTag("Table"))
                    {
                        hit.collider.GetComponent<gameManager1>().gameMNG();
                        //Instruction.text = (test);
                    }
                    // TAG TableSila
                    else if (hit.collider.CompareTag("tableSila1"))
                    {
                        hit.collider.GetComponent<tableSila>().tsSila1();
                    }
                    else if (hit.collider.CompareTag("tableSila2"))
                    {
                        hit.collider.GetComponent<tableSila>().tsSila2();
                    }
                    else if (hit.collider.CompareTag("tableSila3"))
                    {
                        hit.collider.GetComponent<tableSila>().tsSila3();
                    }
                    else if (hit.collider.CompareTag("tableSila4"))
                    {
                        hit.collider.GetComponent<tableSila>().tsSila4();
                    }
                    else if (hit.collider.CompareTag("tableSila5"))
                    {
                        hit.collider.GetComponent<tableSila>().tsSila5();
                    }
                    // TAG TableSila1
                    else if (hit.collider.CompareTag("TS1"))
                    {
                        hit.collider.GetComponent<tableSila1>().tsSila1();
                    }
                    else if (hit.collider.CompareTag("TS2"))
                    {
                        hit.collider.GetComponent<tableSila1>().tsSila2();
                    }
                    else if (hit.collider.CompareTag("TS3"))
                    {
                        hit.collider.GetComponent<tableSila1>().tsSila3();
                    }
                    else if (hit.collider.CompareTag("TS4"))
                    {
                        hit.collider.GetComponent<tableSila1>().tsSila4();
                    }
                    else if (hit.collider.CompareTag("TS5"))
                    {
                        hit.collider.GetComponent<tableSila1>().tsSila5();
                    }
                }

                if (Input.GetButtonDown(closeButton))
                {
                    //If it is a door
                    if (hit.collider.CompareTag("Note"))
                    {
                        //Close it
                        hit.collider.GetComponent<Note>().hideNoteImage();
                    }//If it is a door
                    if (hit.collider.CompareTag("Note1"))
                    {
                        //Close it
                        hit.collider.GetComponent<Note1>().hideNoteImage();
                    }
                }

             }
        }
        else
        {
            interactIcon.enabled = false;
        } 
	}
}
