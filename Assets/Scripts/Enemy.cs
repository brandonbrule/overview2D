using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public GameObject EnemyObj;
	public string type = "horizontal";
	private string direction = "left";
	public int speed = 1;
	public float damage = 10;
	

	// Use this for initialization
	void Start () {
		if(type.Equals("horizontal")){
			direction = "left";
		}

		if(type.Equals("vertical")){
			direction = "up";
		}
	}
	
	// Update is called once per frame
	void Update () {
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


    	if(type.Equals("horizontal")){
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


    
        if (other.gameObject.CompareTag("Wall"))
        {
        	
        	//Debug.Log(direction);
        	
            //Debug.Log("Wall");
        }
    }
}
