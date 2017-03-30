using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{

    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
    bool locked = true;
    bool opening = false;


    void Update() {
        if (opening)
        {
            if(transform.position.y > -7.50f)
            {
                transform.Translate(0, -2.5f * Time.deltaTime, 0, Space.World);
            }

        }
        // If the door is opening and it is not fully raised
            // Animate the door raising up
    }

    public void OnDoorClicked() {
        if (!locked)
        {
            opening = true;
        }else
        {
            Debug.Log("Door stays locked");
        }
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
    }

    public void Unlock()
    {
        locked = false;
        // You'll need to set "locked" to false here
    }
}
