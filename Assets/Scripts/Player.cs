using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private Animator animator;
    public float playerSpeed = 2;



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
    }
	
	// Update is called once per frame
	void Update () {
        Movement();
    }
}
