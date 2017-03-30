using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{

    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
    bool locked = true;
    bool opening = false;

    public AudioSource doorLockedSound;
    public AudioSource doorOpeningSound;



    void Update() {
        if (opening)
        {
            if(transform.position.y > -7.50f)
            {
                transform.Translate(0, -2.5f * Time.deltaTime, 0, Space.World);
            }

        }
    }

    // If the door is clicked and unlocked
    // Set the "opening" boolean to true
    // (optionally) Else
    // Play a sound to indicate the door is locked
    public void OnDoorClicked() {
        if (!locked)
        {
            opening = true;
            doorOpeningSound.Play();
        }
        else
        {
            doorLockedSound.Play();
            Debug.Log("Door stays locked");
        }
    }

    public void Unlock()
    {
        locked = false;
    }
}
