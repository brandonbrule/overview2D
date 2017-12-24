using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpikeMovement : MonoBehaviour {
	public string type = "horizontal";
	private string direction = "left";
	public int speed = 1;
    private AudioSource AudioCollision;


    // Use this for initialization
    void Start () {

        AudioCollision = this.gameObject.GetComponent<AudioSource>();

        if (type.Equals("horizontal")){
			direction = "left";
		}

		if(type.Equals("vertical")){
			direction = "up";
		}
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		if(type.Equals("horizontal")){
			moveHorizontal();
		}

		if(type.Equals("vertical")){
			moveVertical();
		}
	}

	void moveHorizontal(){
		//transform.Translate(Vector3.forward * Time.deltaTime);
		if(direction.Equals("left")){
        	transform.Translate(Vector3.left * (Time.deltaTime * speed), Space.World);
    	}

    	if(direction.Equals("right")){
    		transform.Translate(Vector3.right * (Time.deltaTime * speed), Space.World);
    	}
	}

	void moveVertical(){
		//transform.Translate(Vector3.forward * Time.deltaTime);
		if(direction.Equals("up")){
        	transform.Translate(Vector3.up * (Time.deltaTime * speed), Space.World);
    	}

    	if(direction.Equals("down")){
    		transform.Translate(Vector3.down * (Time.deltaTime * speed), Space.World);
    	}
	}


	void OnTriggerEnter2D(Collider2D other)
    {
        AudioCollision.Play();

        if (type.Equals("horizontal")){
			if(direction.Equals("left")){
				direction = "right";
			} else {
				direction = "left";
			}
		}

		if(type.Equals("vertical")){
			if(direction.Equals("up")){
				direction = "down";
			} else {
				direction = "up";
			}
		}

    }
}
