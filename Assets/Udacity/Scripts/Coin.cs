using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab

    public GameObject puffObject;
    public AudioSource puffSound;

    public void OnCoinClicked() {
        Vector3 coinPosition = transform.position;
        Object.Instantiate(puffObject, coinPosition, Quaternion.Euler(-90, 0, 0));
        puffSound.Play();
        Destroy(this.gameObject);
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
    }

}
