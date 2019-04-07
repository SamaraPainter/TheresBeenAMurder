﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extractor : MonoBehaviour {

    
    public Transform openDoorPos;
    public Transform closedDoorPos;
    public Rigidbody door;
    public Material machineMaterial;
    bool isOn = false;

    public float moveTime = 1f;

   // public AudioSource machinePowerup;
    //public AudioSource doorClicking;


	// Use this for initialization
	void Start () {
		machineMaterial.DisableKeyword("_EMISSION");
    
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            powerOn();
        }
    }

    // Update is called once per frame
    public void powerOn()
    {

        makeItGlow();
        openDoor();
        //machinePowerup.Play();
        
    
    }
    public void closeDoor()
    {
        StartCoroutine(Movement.SmoothMove(closedDoorPos.position, moveTime, door));
        //doorClicking.Play();
    }

    public void openDoor()
    {
        StartCoroutine(Movement.SmoothMove(openDoorPos.position, moveTime, door));
        //doorClicking.Play();
    }

    public void makeItGlow()
    {
        machineMaterial.EnableKeyword("_EMISSION");
        isOn = true;
    }
}