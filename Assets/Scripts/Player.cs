﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public GameObject HealthUI;
    private Animator animator;
    public float playerSpeed = 2;
    public float health = 10;
    public GameObject healthScript;



    void Attack()
    {

    }



    void Movement (){

        // Move Up (W)
        if ( Input.GetKey( KeyCode.W ) ){
            animator.Play("moveUp");
            transform.Translate(0, playerSpeed * Time.deltaTime, 0);
            //animator.SetTrigger(moveUp);
        }

        

        // Move Down (S)
        if ( Input.GetKey( KeyCode.S ) ){
            animator.Play("moveDown");
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            //animator.SetTrigger(moveUp);
        }

        if(Input.GetKeyUp( KeyCode.S ) ){
            animator.Play("Default");
        }


        // Move Left (A)
        if ( Input.GetKey( KeyCode.A ) ){
            animator.Play("moveLeft");
            transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
        }

        // Move Right (D)
        if (Input.GetKey( KeyCode.D ) ){
            animator.Play("moveRight");
            transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
        }


        // Run (Shift)
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerSpeed = 4;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerSpeed = 2;
        }
    }

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();

        Debug.Log(HealthUI);
    }
	
	// Update is called once per frame
	void Update () {
        Movement();
    }

    // Player Has Colided with
    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject);
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log(other.gameObject.GetComponent<Enemy>().damage);
            Debug.Log("Ouch");


            //other.gameObject.SetActive(false);
        }
    }
}
