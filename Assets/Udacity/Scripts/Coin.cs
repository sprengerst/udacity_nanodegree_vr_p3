using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab

    public GameObject puffObject;
    public AudioSource puffSound;
    public SignPost resultSignClass;

    private float floatingSpeed = 1;
    private float floatingAmplitude = 0.1f;

    private float startPositionY;
    void Start()
    {
        startPositionY = transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, startPositionY + floatingAmplitude * Mathf.Sin(floatingSpeed * Time.time), transform.position.z);
    }

    public void OnCoinClicked() {
        resultSignClass.IncrementCoinCount();
        puffSound.Play();
        Vector3 coinPosition = transform.position;
        Object.Instantiate(puffObject, coinPosition, Quaternion.Euler(-90, 0, 0));
        Destroy(this.gameObject);
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
    }

}
