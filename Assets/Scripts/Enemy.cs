using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public GameObject EnemyObj;
	public string direction = "up";
	

	// Use this for initialization
	void Start () {
		Debug.Log(direction);
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}

	void Move(){
		//transform.Translate(Vector3.forward * Time.deltaTime);
		if(direction.Equals("up")){
        	transform.Translate(Vector3.left * Time.deltaTime, Space.World);
    	}

    	if(direction.Equals("down")){
    		transform.Translate(Vector3.right * Time.deltaTime, Space.World);
    	}

	}

	void OnTriggerEnter2D(Collider2D other)
    {
    
        Debug.Log(other.gameObject);
        if (other.gameObject.CompareTag("Wall"))
        {
        	if(direction.Equals("up")){
        		direction = "down";
        	} else {
        		direction = "up";
        	}

        	Debug.Log(direction);
        	
            Debug.Log("Wall");
        }
    }
}
