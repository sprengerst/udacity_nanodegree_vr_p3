using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{

    public GameObject puffObject;
    public AudioSource puffSound;
    public Door doorToOpen;

    public static bool keyCollected = false;

    private float floatingSpeed = 1;
    private float floatingAmplitude = 0.5f;

    private float startPositionY;
    void Start(){
        startPositionY = transform.position.y;
    }

    void Update(){
        transform.position = new Vector3(transform.position.x, startPositionY + floatingAmplitude * Mathf.Sin(floatingSpeed * Time.time), transform.position.z);
	}
    
    public void OnKeyClicked(){

        keyCollected = true;

        puffSound.Play();
        Vector3 coinPosition = transform.position;
        Object.Instantiate(puffObject, coinPosition, Quaternion.Euler(-90, 0, 0));
        Destroy(this.gameObject);
        doorToOpen.Unlock();
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy

    }

}
