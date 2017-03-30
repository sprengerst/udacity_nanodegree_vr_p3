using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour {

    private bool rotate = false;

    public void Update()
    {
        if (rotate && transform.eulerAngles.x < 340)
        {
            Debug.Log("Transform Rotation " + transform.eulerAngles.x);
            transform.Rotate(20 * Time.deltaTime,0, 0);
        }
    }

	// Use this for initialization
	public void Open () {
        Debug.Log("OPEN THIS CHEST");
        rotate = true;
	}
	
}
