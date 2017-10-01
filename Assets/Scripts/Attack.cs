﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
    public GameObject Player;
    public GameObject PlayerActiveItem;


    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        userAttack();
    }

    void userAttack(){
        if (Input.GetKeyDown(KeyCode.E)) //set the key you want to be pressed
        {
            PlayerActiveItem.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.E)) //set the key you want to be pressed
        {

            PlayerActiveItem.SetActive(false);
        }

        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other);
        if (other.gameObject.CompareTag("Chest"))
        {
            other.gameObject.SetActive(false);
        }
    }
}