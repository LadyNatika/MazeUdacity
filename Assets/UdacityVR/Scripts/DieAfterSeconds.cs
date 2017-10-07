using UnityEngine;
using System.Collections;

public class DieAfterSeconds : MonoBehaviour {
    public AudioClip clipClick;

    private AudioSource _audioSource;

    private void Awake() {
        _audioSource = gameObject.GetComponent<AudioSource>();
        _audioSource.playOnAwake = false;
    }

    IEnumerator Start () {
        _audioSource.clip = clipClick;
        _audioSource.Play();
        yield return new WaitForSeconds(2.0f);
        Destroy(gameObject);
	}
}