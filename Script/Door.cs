using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public bool test = false;
    public bool open = false;

    public float doorOpenAngle = 90f;
    public float doorClosedAngle = 0f;

    public float smooth = 2f;

    private AudioSource audioSource;
    public AudioClip openingSound;

    public AudioClip lockedDoorSound;

    public bool isLocked = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ChangeDoorState()
    {
        if (isLocked != true)
        {
            open = !open;

            if (audioSource != null)
            {
                audioSource.PlayOneShot(openingSound);
            }
        }
        else
        {
            PlayLockedDoorSound();
        }

    }

    void PlayLockedDoorSound()
    {
        audioSource.PlayOneShot(lockedDoorSound);
    }

	// Update is called once per frame
	void Update ()
    {
		if(open)
        {
            Quaternion targetRotationOpen = Quaternion.Euler(0, doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationOpen, smooth * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotationClosed = Quaternion.Euler(0, doorClosedAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationClosed, smooth * Time.deltaTime);
        }

        if (test == true)
        {
            ChangeDoorState();
            test = false;
        }
	}
}
