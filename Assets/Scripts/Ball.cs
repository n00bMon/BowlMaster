using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float velocity;

    private Rigidbody rigidBody;
    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = new Vector3(0, 0, velocity);

        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
    }
}
