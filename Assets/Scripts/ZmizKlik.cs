using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZmizniNaKlick : MonoBehaviour
{
    // public AudioSource audioSource;
    // public AudioClip boom;
    [SerializeField]
    KeyCode del;

    private void OnMouseDown() 
    {
        Debug.Log("onmousedown");
        Destroy(gameObject);
        // audioSource.PlayOneShot(boom);
    }

    private void Update() {
        if(Input.GetKey(del))
        {
        Debug.Log("onmousedown");
        Destroy(gameObject);
        }
    }
}
