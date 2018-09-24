using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

    private AudioSource deathSound;


    private void Start()
    {
        deathSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        deathSound.Play();
        PlayerController.setDeadToTrue();
    }
}
