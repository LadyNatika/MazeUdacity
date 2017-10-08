using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectSignPost : MonoBehaviour {

    public GameObject signPost;

    void FixedUpdate()
    {
        float distance = Vector3.Distance(signPost.transform.position, transform.position);
        // Debug.Log((distance < 16f) + " distance to signpost. Real distance - " + distance);
        signPost.GetComponent<GraphicRaycaster>().enabled = distance < 16f;
    }
}
