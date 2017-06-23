using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    private bool locked = true;
    // Create a boolean value called "opening" that can be checked in Update() 
    private bool opening = false;

    public Transform leftDoor;
    public Transform rightDoor;
    public AudioClip doorLocked;
    public AudioClip doorOpened;


    private AudioSource DoorSound;
    private Collider doorCollider;

    private float doorOpenTimer = 0.0f;

    void Start()
    {
        DoorSound = GetComponent<AudioSource>();
        DoorSound.clip = doorLocked;
        doorCollider = GetComponent<Collider>();
    }

    void Update() {
        // If the door is opening and it is not fully raised
        // Animate the door raising up
        if (opening == true)
        {
            if (doorOpenTimer < 3.0f)
            {
                leftDoor.Rotate(0, 0, 35 * Time.deltaTime);
                rightDoor.Rotate(0, 0, -35 * Time.deltaTime);
            }
            doorOpenTimer += Time.deltaTime;
        }
            
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        if(locked == false)
        {
            opening = true;
            DoorSound.Play();
            doorCollider.enabled = false;

        }
        else
        {
            DoorSound.Play();
        }
        // (optionally) Else
            // Play a sound to indicate the door is locked
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked = false;
        DoorSound.clip = doorOpened;
    }
}
