using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoof;
   // public AudioClip clipClick;

    //private AudioSource _audioSource;

  //  private void Awake() {
      //  _audioSource = gameObject.GetComponent<AudioSource>();
      //  _audioSource.clip = clipClick;
     //   _audioSource.playOnAwake = false;
    //}

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        GameObject.Instantiate(coinPoof, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation * Quaternion.Euler(-90f, 0f, 0f));
       
        // Make sure the poof animates vertically
        // Play sound
        //  _audioSource.Play();
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        GameObject.Destroy(gameObject);
    }

}
