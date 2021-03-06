﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    public GameObject keyPoof;
    public GameObject door;
    //Create a reference to the KeyPoofPrefab and Door

    void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        GameObject.Instantiate(keyPoof, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation * Quaternion.Euler(0f, 0f, 0f));

        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        Door doorController = door.GetComponent<Door>();
        doorController.Unlock();
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy
        GameObject.Destroy(gameObject);
    }

}
