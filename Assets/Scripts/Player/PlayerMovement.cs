using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D rbody;
	Animator anim;
	public float playerSpeed = 2;
	private float originalPlayerSpeed;
	public char direction;
	private GameObject PlayerState;

	// Use this for initialization
	void Start () {
		PlayerState = GameObject.Find("Player/PlayerStateManager");
		rbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		originalPlayerSpeed = playerSpeed;
	}

	void setDirection(float x, float y){
		char newDirection = 'a';
		if(x == -1 && y == 0){
			newDirection = 'e';
		} else if(x == 1 && y == 0){
			newDirection = 'w';
		} else if(x == 0 && y == 1){
			newDirection = 'n';
		} else {
			newDirection = 's';
		}
		
		if(newDirection != direction){
			direction = newDirection;
			PlayerState.GetComponent<PlayerState>().updateDirection(direction);
		}

		
	}

	void Run(){
		// Run (Shift)
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerSpeed = 3;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerSpeed = originalPlayerSpeed;
        }


         if (Input.GetKeyDown(KeyCode.E)) //set the key you want to be pressed
        {
            anim.SetBool("isattacking", true);
        }

         if (Input.GetKeyUp(KeyCode.E)) //set the key you want to be pressed
        {

            anim.SetBool("isattacking", false);
        }


	}
	
	// Update is called once per frame
	void Update () {
		Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

		if (movement_vector != Vector2.zero){

			anim.SetBool("iswalking", true);
			anim.SetFloat("input_x", movement_vector.x);
			anim.SetFloat("input_y", movement_vector.y);
			Run();
			setDirection(movement_vector.x, movement_vector.y);
		} else {
			anim.SetBool("iswalking", false);
		}


		

		rbody.MovePosition (rbody.position + ( (movement_vector * Time.deltaTime) * playerSpeed ) );
	}
}
