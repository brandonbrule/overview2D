using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D rbody;
	Animator anim;
	public float playerSpeed = 2;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

	void Run(){
		// Run (Shift)
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerSpeed = 3;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerSpeed = 2;
        }
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

		if (movement_vector != Vector2.zero){

			anim.SetBool("iswalking", true);
			anim.SetFloat("input_x", movement_vector.x);
			anim.SetFloat("input_y", movement_vector.y);
		} else {
			anim.SetBool("iswalking", false);
		}


		Run();

		rbody.MovePosition (rbody.position + ( (movement_vector * Time.deltaTime) * playerSpeed ) );
	}
}
