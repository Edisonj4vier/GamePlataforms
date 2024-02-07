using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsatuCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource crashFX;
    public GameObject mainCamera;
    public GameObject levelController;
    
    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        levelController.GetComponent<LevelDistance>().enabled = false;
        crashFX.Play();
        mainCamera.GetComponent<Animator>().enabled = true;
        levelController.GetComponent<EndController>().enabled = true;
    }
}
