using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    public Animator doorAnimator;
    public AudioClip doorOpenClick;
    public AudioClip doorLockedClick;
   
    private AudioSource _audioSource;
    private bool _unlocked;

    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
    void Awake() {
        _audioSource = gameObject.GetComponent<AudioSource>(); 
    }
    void Update() {
        Animator doorAnimator = gameObject.GetComponent<Animator>();
       
        // If the door is opening and it is not fully raised
        // Animate the door raising up
    }

    public void OnDoorClicked() {
        if (_unlocked) {
            _audioSource.PlayOneShot(doorOpenClick);
            doorAnimator.SetBool("Open", true);
        } else {
            _audioSource.PlayOneShot(doorLockedClick);
        }
         
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        // (optionally) Else
        // Play a sound to indicate the door is locked
    }

    public void Unlock() {
        _unlocked = true;

        // You'll need to set "locked" to false here
    }
}
