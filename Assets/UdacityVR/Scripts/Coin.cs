using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoof;

    private float _basePositionY;

    public void Start() {
        _basePositionY = transform.position.y;    
    }
    public void Update() {
        transform.position = new Vector3(transform.position.x, _basePositionY + Mathf.Sin(Time.time * 3.0f)/2, transform.position.z);
    }

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
