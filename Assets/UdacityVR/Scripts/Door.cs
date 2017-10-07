using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    public Animator doorAnimator;
    public AudioClip doorOpenClick;
    public AudioClip doorLockedClick;
   
    private AudioSource _audioSource;

    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
    void Awake() {
        _audioSource = gameObject.GetComponent<AudioSource>(); 
    }
    void Update() {
        //doorAnimator = gameObject.GetComponent<Animator>;
        Animator doorAnimator = gameObject.GetComponent<Animator>();
       
        // doorAnimator.SetBool("Open", true);
        //doorAnimator.SetBool("Open", false);

        // If the door is opening and it is not fully raised
        // Animate the door raising up
    }

    public void OnDoorClicked() {
        _audioSource.clip = doorLockedClick;
        _audioSource.Play();
       
       // Vector3 fwd = transform.TransformDirection(Vector3.forward);
      //  doorAnimator.SetBool("Open", Physics.Raycast(transform.position, fwd, 2));
     
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        // (optionally) Else
        // Play a sound to indicate the door is locked
    }

    public void Unlock() {
        _audioSource.clip = doorOpenClick;
        _audioSource.Play();
       doorAnimator.SetBool("Open", true);

        // You'll need to set "locked" to false here
    }
}
